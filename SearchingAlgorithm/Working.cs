namespace SearchingAlgorithm
{
    class Working
    {
        public static int SecuentialIterative_Search(int e, int[] v) //e will be the input value to search; v will be the array with the values
        {
            int i = 0;
            v[v.Length - 1] = e; //Add centinela

            while (v[i] != e)
                i++;

            return i % v.Length; //Return the centinela if it does not find it 
        }

        public static int SecuentialRecursive_Search(int e, int[] v, int i)
        {
            v[v.Length - 1] = e;

            if (v[i] == e)
                return i % v.Length;

            return SecuentialRecursive_Search(e, v, ++i);
        }


        public static int BinaryIterative_Search(int e, int[] v)
        {
            int derecha = v.Length - 1;
            int izquierda = 0;
            int posicion;

            while (izquierda <= derecha)
            {
                posicion = (izquierda + derecha) / 2;

                if (v[posicion] == e)
                    return posicion;

                if (v[posicion] > e)
                    derecha = posicion - 1;

                else
                    izquierda = posicion + 1;
            }
            return -1;
        }

        public static int BinaryRecursive_Search(int e, int[] v, int inf, int sup)
        {
            int centro;

            if (inf > sup)
                return -1;

            else
            {
                centro = (inf + sup) / 2;

                if (v[centro] < e)
                    return BinaryRecursive_Search(e, v, centro + 1, sup);

                else if (v[centro] > e)
                    return BinaryRecursive_Search(e, v, inf, centro - 1);

                else
                    return centro;
            }

        }
    }
}
