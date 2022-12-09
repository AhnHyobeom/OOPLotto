using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLotto
{
    public static class Extensions
    {
        public static bool HasDuplications(this List<int> sender) =>
            sender.GroupBy(value => value).Any(@group => @group.Count() > 1);
        public static string ToYesNoString(this bool value) => value ? "Yes" : "No";
    }

    public static class CommDefine
    {
        public const int LOTTO_NUMBER_SIZE = 6;
        public const int LOTTO_RANDOM_START = 1;
        public const int LOTTO_RANDOM_END = 46;

        public static Random rnd = new Random(Guid.NewGuid().GetHashCode());
    }

}
