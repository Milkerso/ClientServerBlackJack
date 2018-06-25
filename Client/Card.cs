using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Card
    {
        private String figure;
        private String color;
        private int value;
        public Card()
        {
        }

        public Card(string figure, string color, int value)
        {
            this.figure = figure;
            this.color = color;
            this.value = value;

        }

        public string Figure { get => figure; set => figure = value; }
        public string Color { get => color; set => color = value; }
        public int Value { get => value; set => this.value = value; }


        public override bool Equals(object obj)
        {
            var card = obj as Card;
            return card != null &&
                   figure == card.figure &&
                   color == card.color &&
                   value == card.value;
        }

        public override int GetHashCode()
        {
            var hashCode = 1929440467;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(figure);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(color);
            hashCode = hashCode * -1521134295 + value.GetHashCode();

            return hashCode;
        }
    }
}
