namespace VinFletchersArrow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arrow arrowTotal = new Arrow(ArrowType(), fletcherType(), ArrowLength());
            float price = arrowTotal.ArrowCost();
            Console.WriteLine($"Your arrow will cost {price} gold.");
            Console.ReadLine();
        }

        static ArrowHeadType ArrowType()
        { 
            while (true)
            { 
                Console.WriteLine("Please select an arrow head type: Steel, Wood, Obsidian");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                case "steel": return ArrowHeadType.Steel;
                case "wood": return ArrowHeadType.Wood;
                case "obsidian": return ArrowHeadType.Obsidian;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
                }

            }
        }
        static FletcherType fletcherType()
        {
            while (true)
            {
                Console.WriteLine("What fletcher type are you wanting plastic, turkey or metal?");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                case "plastic": return FletcherType.Plastic;
                case "turkey": return FletcherType.Turkey;
                case "metal": return FletcherType.Metal;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
                }
            }
        }

        static float ArrowLength()
        {
            float length;
            while (true)
            {
            Console.Write("Choose a length between 60-100cm:");
            float lengthInput = Convert.ToSingle(Console.ReadLine());
                if (lengthInput >= 60 && lengthInput <= 100)
                {
                    length = lengthInput;
                    return length;
                }
                else
                { 
                    Console.WriteLine("Our arrows dont come in that length.");

                }
                continue;
            }
        }
    }

    class Arrow
    {
        private ArrowHeadType _arrowType;
        private FletcherType _fletcherType;
        private float _arrowLength;

        public Arrow(ArrowHeadType arrowType, FletcherType flrtcherType, float arrowLength)
        {
            _arrowType = arrowType;
            _fletcherType = flrtcherType;
            _arrowLength = arrowLength;

        }

        public float ArrowCost()
        {
            float cost = 0f;
            switch (_arrowType)
            {
                case ArrowHeadType.Steel: cost += 10f; break;
                case ArrowHeadType.Wood: cost += 3f; break;
                case ArrowHeadType.Obsidian: cost += 5f; break;
            
            }
            switch (_fletcherType)
            {
                case FletcherType.Plastic:cost += 10f; break;
                case FletcherType.Turkey:cost += 5f; break;
                case FletcherType.Metal:cost += 3f; break;

            }
            cost += _arrowLength * 0.05f;

            return cost;
        }
    }

    enum ArrowHeadType {Steel, Wood, Obsidian}
    enum FletcherType {Plastic, Turkey, Metal}
}
