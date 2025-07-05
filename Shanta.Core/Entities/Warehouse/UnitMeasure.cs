using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Entities.Warehouse
{
    public enum UnitMeasure
    {
        Piece,        // Individual item, e.g., a single book or a single piece of clothing
        Kilogram,     // Weight in kilograms, e.g., for bulk items like grains or produce
        Liter,        // Volume in liters, e.g., for liquids like milk or juice
        Meter,        // Length in meters, e.g., for fabric or rope
        Box,          // A box containing multiple items, e.g., a box of chocolates or a box of toys
        Pallet,       // A pallet containing multiple boxes or items, typically used in shipping and storage
        Carton,       // A carton containing multiple items, often used for packaging and shipping
        Bundle        // A bundle of items tied together, e.g., a bundle of newspapers or a bundle of firewood
    }
}
