using dmt;
namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Working");
            Menu menu = new(new List<Tuple<string, Action>>
    {
        Tuple.Create("Action 1",new Action(()=>{Action1(); })),
        Tuple.Create("Action 2",new Action(()=>{Action2(); })),
        Tuple.Create("Action 3",new Action(()=>{Action3(); })),
        Tuple.Create("Action 4",new Action(()=>{Action4(); })),
        Tuple.Create("Action 5",new Action(()=>{Action5(); })),

    }); ;

            menu.Create();

            void Action1()
            {
                Console.WriteLine("Action1!");
            }
            void Action2()
            {
                Console.WriteLine("Action2!");
            }
            void Action3()
            {
                Console.WriteLine("Action3!");
            }
            void Action4()
            {
                Console.WriteLine("Action4!");
            }
            void Action5()
            {
                Console.WriteLine("Action5!");
            }
        }
    }
    
}