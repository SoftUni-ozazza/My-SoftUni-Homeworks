namespace StringDisperser
{
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using System.Text;

    public class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable<char>
    {
        private StringBuilder textBuilder;

        public StringDisperser(params string[] strings)
        {
            this.TextBuilder = new StringBuilder();
            foreach (var str in strings)
            {
                this.TextBuilder.Append(str);
            }
        }

        public StringBuilder TextBuilder
        {
            get
            {
                return this.textBuilder;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("textBuilder", "String can not be empty or null");
                }

                this.textBuilder = value;
            }
        }

        public override string ToString()
        {
            return this.TextBuilder.ToString();
        }

        public override bool Equals(object obj)
        {
            StringDisperser stringDisperser = obj as StringDisperser;
            if (stringDisperser == null)
            {
                return false;
            }

            string thisTotalString = this.TextBuilder.ToString();
            string stringDisperserTotalString = stringDisperser.textBuilder.ToString();

            return thisTotalString.Equals(stringDisperserTotalString);
        }

        public static bool operator ==(StringDisperser stringDisperser, StringDisperser otherStringDisperser)
        {
            return Object.Equals(stringDisperser, otherStringDisperser);
        }

        public static bool operator !=(StringDisperser stringDisperser, StringDisperser otherStringDisperser)
        {
            return Object.Equals(stringDisperser, otherStringDisperser);
        }

        public override int GetHashCode()
        {
            return this.TextBuilder.GetHashCode();
        }

        public object Clone()
        {
            StringDisperser newText = this.MemberwiseClone() as StringDisperser;
            if (newText == null)
            {
                throw new ArgumentNullException("Object can't be casted to StringDisperser type!");
            }

            newText.TextBuilder = new StringBuilder().Append(this.TextBuilder.ToString());

            return newText;
        }

        public int CompareTo(StringDisperser other)
        {
            string thisTotalString = this.TextBuilder.ToString();
            string otherTotalString = other.textBuilder.ToString();

            return thisTotalString.CompareTo(otherTotalString);
        }

        public IEnumerator<char> GetEnumerator()
        {
            for (int i = 0; i < this.TextBuilder.Length; i++)
            {
                yield return this.TextBuilder[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}