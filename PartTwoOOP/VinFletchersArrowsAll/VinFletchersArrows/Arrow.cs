using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VinFletchersArrows
{
    public class Arrow
    {
        public enum ArrowheadType {Steel, Wood, Obsidian};
        public enum FletchingType {Plastic, TurkeyFeathers, GooseFeathers};
        public ArrowheadType Arrowhead { get; }
        public FletchingType Fletching { get; }
        public float Length { get; }

        public Arrow(ArrowheadType arrowhead, FletchingType fletching, float length)
        {
            Arrowhead = arrowhead;
            Fletching = fletching;
            Length = length;
        }
        public Arrow GetArrow()
        {
            Console.WriteLine("Please either select:\n1 - Elite Arrow\n2 - Beginner Arrow\n3 - Marksman Arrow\n4 - Custom Arrow");
            Console.WriteLine();
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    return CreateEliteArrow();
                case 2:
                    return CreateBeginnerArrow();
                case 3:
                    return CreateMarksmanArrow();
                case 4:
                    ArrowheadType arrowhead = GetArrowheadType();
                    FletchingType fletching = GetFletchingType();
                    float length = GetLength();
                    return new Arrow(arrowhead, fletching, length);
                default:
                    Console.WriteLine("Incorrect Selection, try again.");
                    return GetArrow();
            }
            
        }
        public static Arrow CreateEliteArrow()
        {
            Arrow arrow = new Arrow(ArrowheadType.Steel, FletchingType.Plastic, 95);
            return arrow;
        }
        public static Arrow CreateBeginnerArrow()
        {
            Arrow arrow = new Arrow(ArrowheadType.Wood, FletchingType.GooseFeathers, 75);
            return arrow;
        }
        public static Arrow CreateMarksmanArrow()
        {
            Arrow arrow = new Arrow(ArrowheadType.Steel, FletchingType.GooseFeathers, 65);
            return arrow;
        }
        public static ArrowheadType GetArrowheadType()
        {
            Console.WriteLine("Please pick an arrowhead type by selecting a number:\n1 - Steel" +
                "\n2 - Wood\n3 - Obsidian");
            Console.WriteLine();
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    return ArrowheadType.Steel;
                case 2:
                    return ArrowheadType.Wood;
                case 3: 
                    return ArrowheadType.Obsidian;
                default:
                    Console.WriteLine("Incorrect Selection, try again.");
                    return GetArrowheadType();

            }
        }
        public static FletchingType GetFletchingType()
        {
            Console.WriteLine("Please pick a fletching type by selecting a number:\n1 - Plastic" +
                "\n2 - Turkey Feathers\n3 - Goose Feathers");
            Console.WriteLine();
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    return FletchingType.Plastic;
                case 2:
                    return FletchingType.TurkeyFeathers;
                case 3:
                    return FletchingType.GooseFeathers;
                default:
                    Console.WriteLine("Incorrect Selection, try again.");
                    return GetFletchingType();
            }
        }
        public static int GetLength()
        {
            Console.Write("Please select a shaft length between 60 and 100");
            Console.WriteLine();
            int input = Convert.ToInt32(Console.ReadLine());
            if(input >= 60 && input <= 100)
            {
                return input;
            }
            else
            {
                Console.WriteLine("Incorrect Selection, try again.");
                return GetLength();
            }
        }
        public float GetCost()
        {
            float arrowheadCost = 0;
            float fletchingCost = 0;
            
            switch (Arrowhead)
            {
                case ArrowheadType.Steel:
                    arrowheadCost = 10;
                    break;
                case ArrowheadType.Wood:
                    arrowheadCost = 3;
                    break;
                case ArrowheadType.Obsidian:
                    arrowheadCost = 5;
                    break;
            }
            switch (Fletching)
            {
                case FletchingType.Plastic:
                    fletchingCost = 10;
                    break;
                case FletchingType.TurkeyFeathers:
                    fletchingCost = 5;
                    break;
                case FletchingType.GooseFeathers:
                    fletchingCost = 3;
                    break;
            }
            float lengthCost = Length * .05f;
            return lengthCost + arrowheadCost + fletchingCost;
        }
    }
}
