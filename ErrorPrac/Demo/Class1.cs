using System;

namespace Demo
{
    public class DemoCode
    {
        public int gpm(int p)
        {
            return pm(p);
        }
        public int pm(int p)
        {
            return getNums(p);
        }
        public int getNums(int p)
        {
            int[] nums = new int[] { 3, 1, 9, 5 };
            return nums[p];
        }
    }
}
