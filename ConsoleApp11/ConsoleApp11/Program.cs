﻿using System;
using System.Collections.Generic;

namespace ConsoleApp11;
    class Program { 
public class Part : IEquatable<Part>
{
    public string? PartName { get; set; }

    public int PartId { get; set; }

    public override string ToString()
    {
        return "ID: " + PartId + "   Name: " + PartName;
    }
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        Part? objAsPart = obj as Part;
        if (objAsPart == null) return false;
        else return Equals(objAsPart);
    }
    public override int GetHashCode()
    {
        return PartId;
    }
    public bool Equals(Part other)
    {
        if (other == null) return false;
        return (this.PartId.Equals(other.PartId));
    }
    
}
    public class Example
    {
        public static void Main()
        {
            
            List<Part> parts = new List<Part>();

            
            parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
            parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
            parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
            parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
            parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
            parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });

            
            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            
            Console.WriteLine("\nContains(\"1734\"): {0}",
            parts.Contains(new Part { PartId = 1734, PartName = "" }));

            Console.WriteLine("\nInsert(2, \"1834\")");
            parts.Insert(2, new Part() { PartName = "brake lever", PartId = 1834 });

            
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            Console.WriteLine("\nParts[3]: {0}", parts[3]);

            Console.WriteLine("\nRemove(\"1534\")");

           
            parts.Remove(new Part() { PartId = 1534, PartName = "cogs" });

            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }
            Console.WriteLine("\nRemoveAt(3)");
            
            parts.RemoveAt(3);

            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }
           

        }
    }
}

