using Stendinator.Console.Components;
using Stendinator.Console.Components.AbstractFactories;
using Stendinator.Console.Creatures.Factories;
using Stendinator.Core;
using Stendinator.Core.Components;
using Stendinator.Core.Components.Factories;
using Stendinator.Core.CreatureControllers;
using Stendinator.Core.Creatures;
using Stendinator.Core.Creatures.Builders;
using Stendinator.Core.Planets.Factories;
using static System.Int32;

namespace Stendinator.Console
{
    public class Program
    {
        private static readonly CyborgBuilder Builder = new();
        private static readonly AbstractComponentFactory AbstractComponentFactory = new();
        private static readonly ActiveComponentFactory ActiveComponentFactory = new();
        private static readonly RandomComponentFactory RandomComponentFactory = new();
        private static readonly DecoratedRandomAlienFactory DecoratedRandomAlienFactory = new(RandomComponentFactory);
        private static readonly DecoratedRandomCyborgFactory DecoratedRandomCyborgFactory = new(RandomComponentFactory);

        private static DecoratedCreature _player = null!;
        private static RandomCreatureController _enemyController = null!;

        public static void Main(string[] _)
        {
            Intro();
            _player = new DecoratedCreature(Build(AbstractComponentFactory));
            _player.Print();
            ComponentDetails(_player.Components);
            PauseAndClear();
            var game = new Game(RandomComponentFactory, new RandomPlanetFactory(DecoratedRandomAlienFactory, DecoratedRandomCyborgFactory), _player);
            game.EnemyIsBeaten += EnemyIsBeaten;
            game.PlanetIsBeaten += (_, _) =>
            {
                System.Console.WriteLine($"\n\nYou have beaten the current planet, the level has been incremented to {GameState.Instance.CurrentStage}");
                PauseAndClear();
            };
            _enemyController = new RandomCreatureController(game.CurrentPlanet.CurrentEnemy);
            _enemyController.NoActiveComponents += (_, _) =>
            {
                System.Console.WriteLine("\n\nThe enemy has no active components, so he cant attack...");
                PauseAndClear();
            };
            _enemyController.ComponentUsed += (ac) =>
            {
                System.Console.WriteLine($"\n\nThe enemy used {ac.GetType().Name}");
                PauseAndClear();
            };
            _player.CreatureBeaten += (_, _) =>
            {
                System.Console.WriteLine($"\n\nYou have been beaten and made it to level {GameState.Instance.CurrentStage}");
                PauseAndClear();
                Environment.Exit(0);
            };
            while (true)
            {
                if (GameState.Instance.Turn == Turn.Player)
                {
                    System.Console.WriteLine("It's your turn to attack!");
                    var activeComponents = _player.Components.Where(c => c.GetType().IsSubclassOf(typeof(ActiveComponent))).Cast<ActiveComponent>().ToArray();
                    if (activeComponents.Any())
                    {
                        System.Console.WriteLine("Select the preferred active component to attack with:\n");
                        ComponentsWithIndex(activeComponents);
                        var chosenActiveComponent = ReadIndex(activeComponents.Length);
                        System.Console.WriteLine($"You have chosen {activeComponents[chosenActiveComponent].GetType().Name}\n");
                        activeComponents[chosenActiveComponent].Activate();
                        System.Console.WriteLine("Enemy stats:");
                        ((DecoratedCreature)game.CurrentPlanet.CurrentEnemy).Print();
                        PauseAndClear();
                    }
                    else
                    {
                        System.Console.WriteLine("You have no active components, so you cant attack...");
                        PauseAndClear();
                    }
                }
                else
                {
                    System.Console.WriteLine("The enemy is attacking...");
                    _enemyController.Act();
                    System.Console.WriteLine("Your stats:");
                    _player.Print();
                }
                GameState.Instance.NextTurn();
            }
        }
        
        private static void Intro()
        {
            System.Console.WriteLine("Welcome to the Stendinator universe!");
            PauseAndClear();
            System.Console.WriteLine("Lets build you a Cyborg first, so you can slay Aliens and other Cyborg that have malicious intentions...");
            PauseAndClear();
        }

        private static Creature Build(AbstractComponentFactory abstractConsoleComponentFactory)
        {
            //Build head
            System.Console.WriteLine("Lets add a head first (type the id of the preferred head):\n");
            var headNames = abstractConsoleComponentFactory.GetHeadNames();
            System.Console.WriteLine(NamesToString(headNames));
            var chosenHead = ReadIndex(headNames.Length);
            Builder.AddHead(abstractConsoleComponentFactory.CreateHead(headNames[chosenHead], false));
            System.Console.WriteLine($"Added {headNames[chosenHead]}");
            PauseAndClear();

            //Build body
            System.Console.WriteLine("Add a body (again type the id):\n");
            var bodyNames = abstractConsoleComponentFactory.GetBodyNames();
            System.Console.WriteLine(NamesToString(bodyNames));
            var chosenBody = ReadIndex(bodyNames.Length);
            Builder.AddBody(abstractConsoleComponentFactory.CreateBody(bodyNames[chosenBody], false));
            System.Console.WriteLine($"Added {bodyNames[chosenBody]}");
            PauseAndClear();

            //Build right arm
            System.Console.WriteLine("Add a right arm:\n");
            var rightArmNames = ActiveComponentFactory.GetNames();
            System.Console.WriteLine(NamesToString(rightArmNames));
            var chosenRightArm = ReadIndex(rightArmNames.Length);
            Builder.AddRightArm(ActiveComponentFactory.Create(rightArmNames[chosenRightArm], false));
            System.Console.WriteLine($"Added {rightArmNames[chosenRightArm]}");
            PauseAndClear();

            //Build left arm
            System.Console.WriteLine("Add a left arm:\n");
            var leftArmNames = ActiveComponentFactory.GetNames();
            System.Console.WriteLine(NamesToString(leftArmNames));
            var chosenLeftArm = ReadIndex(leftArmNames.Length);
            Builder.AddLeftArm(ActiveComponentFactory.Create(leftArmNames[chosenLeftArm], false));
            System.Console.WriteLine($"Added {leftArmNames[chosenLeftArm]}");
            PauseAndClear();

            //Build right leg
            System.Console.WriteLine("Add a right leg:\n");
            var rightLegNames = abstractConsoleComponentFactory.GetLegNames();
            System.Console.WriteLine(NamesToString(rightLegNames));
            var chosenRightLeg = ReadIndex(rightLegNames.Length);
            Builder.AddRightLeg(abstractConsoleComponentFactory.CreateLeg(rightLegNames[chosenRightLeg], false));
            System.Console.WriteLine($"Added {rightLegNames[chosenRightLeg]}");
            PauseAndClear();

            //Build left leg
            System.Console.WriteLine("Add a left leg:\n");
            var leftLegNames = abstractConsoleComponentFactory.GetLegNames();
            System.Console.WriteLine(NamesToString(leftLegNames));
            var chosenLeftLeg = ReadIndex(leftLegNames.Length);
            Builder.AddLeftLeg(abstractConsoleComponentFactory.CreateLeg(leftLegNames[chosenLeftLeg], false));
            System.Console.WriteLine($"Added {leftLegNames[chosenLeftLeg]}");
            PauseAndClear();

            return Builder.GetCreature();
        }

        private static string NamesToString(IEnumerable<string> names)
        {
            return names.Select((x, i) => $"{i}: {x}\n").Aggregate("", (c, s) => c + s);
        }

        private static void PauseAndClear()
        {
            System.Console.WriteLine("\n\nEnter to continue...");
            System.Console.ReadLine();
            System.Console.Clear();
        }

        private static void ComponentDetails(IEnumerable<Component> components)
        {
            System.Console.WriteLine($"Components:\n");
            System.Console.WriteLine(components.Select(x =>
                "     " +
                $"{x.GetType().Name} - PassiveStats (Health: {x.PassiveStats.Health}, Defense: {x.PassiveStats.Defense})\n"
            ).Aggregate("", (c, s) => c + s));
        }

        private static void EnemyIsBeaten(object? s, EventArgs e)
        {
            System.Console.WriteLine("\n\nYou have beaten the enemy!");
            System.Console.WriteLine("Components have been dropped, and have been picked up...");
            PauseAndClear();
            System.Console.WriteLine("Select a component that you would like to use:");
            ComponentsWithIndex(GameState.Instance.Components);
            var chosenComponent = ReadIndex(GameState.Instance.Components.Count);
            System.Console.WriteLine($"You selected {GameState.Instance.Components[chosenComponent].GetType().Name}");
            PauseAndClear();
            System.Console.WriteLine("Select a component you want to replace it with:");
            ComponentsWithIndex(_player.Components);
            var componentToReplace = ReadIndex(_player.Components.Length);
            System.Console.WriteLine($"Component: {_player.Components[componentToReplace].GetType().Name} has been replaced by: {GameState.Instance.Components[chosenComponent].GetType().Name}");
            _player.Components[componentToReplace] = GameState.Instance.Components[chosenComponent];
            if (_player.Components[componentToReplace].GetType().IsSubclassOf(typeof(ActiveComponent)))
                ((ActiveComponent) _player.Components[componentToReplace]).ComponentActivated += _player.HandleActivatedComponent;
            GameState.Instance.Components.RemoveAt(chosenComponent);
        }

        private static void ComponentsWithIndex(IEnumerable<Component> components)
        {
            System.Console.WriteLine(components.Select((x, i) =>
                "     " +
                $"{i}: {x.GetType().Name} - PassiveStats (Health: {x.PassiveStats.Health}, Defense: {x.PassiveStats.Defense})\n"
            ).Aggregate("", (c, s2) => c + s2));
        }

        private static int ReadIndex(int range)
        {
            _ = TryParse(System.Console.ReadLine(), out var integer);
            if (integer < 0 || range <= integer) return 0;
            return integer;
        }
    }
}