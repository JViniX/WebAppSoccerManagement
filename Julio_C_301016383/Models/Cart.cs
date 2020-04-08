using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Julio_C_301016383.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public virtual void AddItem(Match match, int quantity)
        {
            CartLine line = lineCollection.FirstOrDefault(m => m.Match.MatchID == match.MatchID);
                
            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Match = match,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Match match) =>
            lineCollection.RemoveAll(l => l.Match.MatchID == match.MatchID);

        public virtual decimal ComputeTotalValue() =>
            lineCollection.Sum(e => e.Match.Price * e.Quantity);

        public virtual void Clear() => lineCollection.Clear();

        public virtual IEnumerable<CartLine> Lines => lineCollection;
    }

    public class CartLine
    {
        public int CartLineID { get; set; }
        public Match Match { get; set; }
        public int Quantity { get; set; }
    }
}
