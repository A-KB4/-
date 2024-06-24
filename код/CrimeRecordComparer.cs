using System.Collections.Generic;

namespace YourNamespace
{
    public class CrimeRecordComparer : IComparer<CrimeRecord>
    {
        public int Compare(CrimeRecord x, CrimeRecord y)
        {
            return x.LastName.CompareTo(y.LastName);
        }
    }
}
