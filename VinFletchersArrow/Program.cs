namespace VinFletchersArrow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        Arrow CreateArrow()
        {
            Arrow arrow = new Arrow(ArrowType(), fletcherType(), ArrowLength());
            return arrow;
        }
        ArrowHeadType ArrowType()
        { 
            while (true)
            { 
                Console.WriteLine("Please select an arrow head type: Steel, Wood, Obsidian");
                string input = Console.ReadLine().ToLower();

                return input switch
                {
                    "steel" => ArrowHeadType.Steel,
                    "wood" => ArrowHeadType.Wood,
                    "obsidian" => ArrowHeadType.Obsidian,
                };


            }
        }
        FletcherType fletcherType()
        {
            while (true)
            {
                Console.WriteLine("What fletcher type are you wanting plastic, wood or metal?");
                string input = Console.ReadLine().ToLower();

                return input switch
                {
                    "plastic" => FletcherType.Plastic,
                    "wood" => FletcherType.Wood,
                    "metal" => FletcherType.Metal,
                };
            }
        }

        float ArrowLength()
        {
            float length;
            while (true)
            Console.Write("Choose a length between 60-100cm:");
            float lengthInput = Convert.ToSingle(Console.ReadLine());
            {
                if (lengthInput >= 60 && lengthInput <= 100)
                {
                    length = lengthInput;
                }
                else
                { 
                    Console.WriteLine("Our arrows dont come in that length.");
                }
            }
        }
    }

    class Arrow
    {
        private ArrowHeadType _arrowType;
        private FletcherType _fletcherType;
        private float _arrowLength;

        public Arrow()
        { 
        }
        public Arrow(ArrowHeadType arrowType, FletcherType flrtcherType, float arrowLength)
        { 
            _arrowType = arrowType;
            _fletcherType = flrtcherType;
            _arrowLength = arrowLength;
             
        }
    }

    enum ArrowHeadType {Steel, Wood, Obsidian}
    enum FletcherType {Plastic, Wood, Metal}
}
