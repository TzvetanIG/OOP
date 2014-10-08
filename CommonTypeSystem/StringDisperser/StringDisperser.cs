using System;
using System.Collections;

namespace StringDisperser
{
    class StringDisperser : ICloneable, IComparable, IEnumerable
    {
        public string[] strings;

        public StringDisperser(params string[] strings)
        {
            this.strings = strings;
        }

        public override string ToString()
        {
            return string.Join("", this.strings);
        }

        public override bool Equals(object obj)
        {
            return this.ToString() == ((StringDisperser)obj).ToString();
        }

        public static bool operator ==(StringDisperser str1, StringDisperser str2)
        {
            return str1.Equals(str2);
        }

        public static bool operator !=(StringDisperser str1, StringDisperser str2)
        {
            return !str1.Equals(str2);
        }

        public override int GetHashCode()
        {
            var newHashCode = 0;
            foreach (var str in strings)
            {
                newHashCode ^= str.GetHashCode();
            }

            return newHashCode;
        }

        public object Clone()
        {
            var cloning = new StringDisperser((string[])this.strings.Clone());
            return cloning;
        }

        public int CompareTo(object obj)
        {
            return this.ToString().CompareTo(obj.ToString());
        }

        public IEnumerator GetEnumerator()
        {
            var str = this.ToString();
            var length = str.Length;
            for (var i = 0; i < length; i++)
            {
                yield return str[i];
            }
        }
    }
}
