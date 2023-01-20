using System.Collections.Concurrent;
using System.Formats.Asn1;
using System.Globalization;
using System.IO.Pipes;

internal class Program
{
    private static void menu()
    {
        Console.WriteLine("1.Calculati suma elementelor unui vector de n numere citite de la tastatura.");
        Console.WriteLine("2.Se da un vector cu n elemente si o valoare k.");
        Console.WriteLine("3.Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.");
        Console.WriteLine("4.Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.");
        Console.WriteLine("5.Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k.");
        Console.WriteLine("6.Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k.");
        Console.WriteLine("7.Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector.");
        Console.WriteLine("8.Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga.");
        Console.WriteLine("9.Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.");
        Console.WriteLine("10.Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare.\nSe cere sa se determine pozitia unui element dat k.");
        Console.WriteLine("11.Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).");
        Console.WriteLine("12.Sortare selectie. Implementati algoritmul de sortare <Selection Sort>.");
        Console.WriteLine("13.Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>.");
        Console.WriteLine("14.Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit.");
        Console.WriteLine("15.Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector.");
        Console.WriteLine("16.Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.");
        Console.WriteLine("17.Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.");
        Console.WriteLine("18.Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. \n" +
            "Cel mai putin semnificativ coeficient este pe pozitia zero in vector.\n" +
            "Se cere valoarea polinomului intr-un punct x.");
        Console.WriteLine("19.Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta).\n" +
            "Determinati de cate ori apare p in s.");
        Console.WriteLine("20.Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2.\n" +
            "Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare.");
        Console.WriteLine("21.Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar).");
        Console.WriteLine("22.Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1");
        Console.WriteLine("23.Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare.");
        Console.WriteLine("24.Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare");
        Console.WriteLine("25.(Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2.");
        Console.WriteLine("26.Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie).\n" +
            "Se cere sa se determine suma, diferenta si produsul a doua astfel de numere.");
        Console.WriteLine("27. Se da un vector si un index in vectorul respectiv.\n" +
            "Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat.");
        Console.WriteLine("28.Quicksort. Sortati un vector folosind metoda QuickSort.");
        Console.WriteLine("29.MergeSort. Sortati un vector folosind metoda MergeSort.");
        Console.WriteLine("30.Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i].\n" +
            "Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima");
        Console.WriteLine("31.Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu m");
    }
    private static void Main(string[] args)
    {
        bool flag = true;
        while (flag)
        {
            string choice = "";
            menu();
            Console.WriteLine("\n");
            Console.WriteLine("Scrie numarul optiunii:");
            choice = Console.ReadLine().ToLower();
            Console.WriteLine("\n");
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Raspuns: {0}", pb1());
                    break;
                case "2":
                    Console.WriteLine("Raspuns: {0}", pb2());
                    break;
                case "3":
                    Console.WriteLine("Raspuns: {0}", pb3());
                    break;
                case "4":
                    Console.WriteLine("Raspuns: {0}", pb4());
                    break;
                case "5":
                    Console.WriteLine("Raspuns: {0}", pb5());
                    break;
                case "6":
                    Console.WriteLine("Raspuns: {0}", pb6());
                    break;
                case "7":
                    Console.WriteLine("Raspuns: {0}", pb7());
                    break;
                case "8":
                    Console.WriteLine("Raspuns: {0}", pb8());
                    break;
                case "9":
                    Console.WriteLine("Raspuns: {0}", pb9());
                    break;
                case "10":
                    Console.WriteLine("Raspuns: {0}", pb10());
                    break;
                case "11":
                    Console.WriteLine("Raspuns: {0}", pb11());
                    break;
                case "12":
                    Console.WriteLine("Raspuns: {0}", pb12());
                    break;
                case "13":
                    Console.WriteLine("Raspuns: {0}", pb13());
                    break;
                case "14":
                    Console.WriteLine("Raspuns: {0}", pb14());
                    break;
                case "15":
                    Console.WriteLine("Raspuns: {0}", pb15());
                    break;
                case "16":
                    Console.WriteLine("Raspuns: {0}", pb16());
                    break;
                case "17":
                    Console.WriteLine("Raspuns: {0}", pb17());
                    break;
                case "18":
                    Console.WriteLine("Raspuns: {0}", pb18());
                    break;
                case "19":
                    Console.WriteLine("Raspuns: {0}", pb19());
                    break;
                case "20":
                    Console.WriteLine("Raspuns: {0}", pb20());
                    break;
                case "21":
                    Console.WriteLine("Raspuns: {0}", pb21());
                    break;
                case "22":
                    Console.WriteLine("Raspuns: {0}", pb22());
                    break;
                case "23":
                    Console.WriteLine("Raspuns: {0}", pb23());
                    break;
                case "24":
                    Console.WriteLine("Raspuns: {0}", pb24());
                    break;
                case "25":
                    Console.WriteLine("Raspuns: {0}", pb25());
                    break;
                case "26":
                    Console.WriteLine("Raspuns: {0}", pb26());
                    break;
                case "27":
                    Console.WriteLine("Raspuns: {0}", pb27());
                    break;
                case "28":
                    Console.WriteLine("Raspuns: {0}", pb28());
                    break;
                case "29":
                    Console.WriteLine("Raspuns: {0}", pb29());
                    break;
                case "30":
                    Console.WriteLine("Raspuns: {0}", pb30());
                    break;
                case "31":
                    Console.WriteLine("Raspuns: {0}", pb31());
                    break;
                case "x":
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Comanda inexistenta reincercati!");
                    break;
            }
            Console.WriteLine("\n");
        }
    }

    private static int pb31()
    {
        throw new NotImplementedException();
    }

    private static int pb30()
    {
        throw new NotImplementedException();
    }

    static void mergeSort(int[] v, int st, int dr)
    {
        if(dr < dr)
        {
            int mid = (dr + dr) / 2;
            mergeSort(v, st, mid);
            mergeSort(v, mid + 1, dr);
            merge(v, st, mid, dr);
        }
    }

    static void merge(int[] v, int st, int mid, int dr)
    {
        int m1 = mid - st + 1;
        int m2 = dr - mid;

        int[] vS = new int[m1];
        int[] vD = new int[m2];

        //luam cele 2 jumatati si ne construim 2 vectori
        for(int i = 0; i < m1; i++)
        {
            vS[i] = v[st + i];
        }
        for(int i = 0; i < m2; i++)
        {
            vD[i] = v[mid + 1 + i];
        }

        //
        int a = 0, b = 0;

        int k = st;
        //sortam elementele prin interclasare
        while(a < m1 && b < m2)
        {
            if (vS[a] <= vD[b])
            {
                v[k] = vS[a];
                a++;
            } else
            {
                v[k] = vD[b];
                b++;
            }
            k++;
        }

        while(a < m1)
        {
            v[k] = vS[a];
            a++;
            k++;
        }

        while (b < m2)
        {
            v[k] = vS[b];
            b++;
            k++;
        }
    }

    private static string pb29()
    {
        int[] v = new int[1000];
        int n;
        int x;
        string ans = "";
        Console.WriteLine("Scrie numarul n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Scrie numarul de pe pozitia {0}: ", i);
            x = int.Parse(Console.ReadLine());
            v[i] = x;
        }

        mergeSort(v, 0, n - 1);

        for (int i = 0; i < i; i++)
        {
            ans += v[i] + ", ";
        }

        return ans;
    }

    static void QuickSsort(int[] v, int st, int dr)
    {
        if(st < dr)
        {
            int pivot = Partition(v, st, dr);

            if(pivot > 1)
            {
                QuickSsort(v, st, pivot - 1);
            }
            if(pivot + 1 < dr)
            {
                QuickSsort(v, pivot + 1, dr);
            }
        }
    }

    static int Partition(int[] v, int st, int dr)
    {
        int pivot = v[st];
        while (true)
        {
            while (v[st] < pivot)
            {
                st++;
            }
            while (v[st] > pivot)
            {
                dr--;
            }
            if(st < dr)
            {
                if (v[st] == v[dr])
                    return dr;
                int temp = v[st];
                v[st] = v[dr];
                v[dr] = temp;
            }
            else
            {
                return dr;
            }
        }
    }
    private static string pb28()
    {
        int[] v = new int[1000];
        int n;
        int x;
        string ans = "";
        Console.WriteLine("Scrie numarul n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Scrie numarul de pe pozitia {0}: ", i);
            x = int.Parse(Console.ReadLine());
            v[i] = x;
        }

        QuickSsort(v, 0, n - 1);

        for (int i = 0; i < i; i++)
        {
            ans += v[i] + ", ";
        }

        return ans;
    }
    private static string pb27()
    {
        int[] v = new int[1000];
        int n;
        int x, index = 0;
        Console.WriteLine("Scrie numarul n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Scrie numarul de pe pozitia {0}: ", i);
            x = int.Parse(Console.ReadLine());
            v[i] = x;
        }

        Console.WriteLine("Scrie index-ul: ");
        index = int.Parse(Console.ReadLine());

        if(index > n)
        {
            return "Index-ul este mai mare decat lungimea vecotorului";
        }

        //sortam vectorul
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (v[j] < v[i])
                {
                    int aux = v[i];
                    v[i] = v[j];
                    v[j] = aux;
                }
            }
        }

        return "" + v[index];
;    }

    //TODO
    private static int pb26()
    {
        throw new NotImplementedException();
    }
    
    //TODO
    private static int pb25()
    {
        throw new NotImplementedException();
    }

    //TODO
    private static int pb24()
    {
        throw new NotImplementedException();
    }

    //TODO
    private static int pb23()
    {
        throw new NotImplementedException();
    }

    //TODO
    private static int pb22()
    {
        throw new NotImplementedException();
    }

    //TODO
    private static string pb21()
    {
        int[] v = new int[1000];
        int[] w = new int[1000];
        int n,m;
        int x, div = 0;
        Console.WriteLine("Scrie numarul n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Scrie numarul de pe pozitia {0} pentru primul vector: ", i);
            x = int.Parse(Console.ReadLine());
            v[i] = x;
        }
        Console.WriteLine("Scrie numarul m: ");
        m = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine("Scrie numarul de pe pozitia {0} pentru al doilea vector: ", i);
            x = int.Parse(Console.ReadLine());
            v[i] = x;
        }

        int min = Math.Min(n, m);
        for(int i = 0; i < min; i++)
        {
            if (v[i] != w[i])
            {
                if (v[i] > w[i])
                {
                    return "Vectorul 1 este primul in ordine lexicografica";
                } else
                {
                    return "Vectorul 2 este primul in ordine lexicografica";
                }
            }
        }
        return "Vectorii sunt identici";
    }

    //TODO
    private static int pb20()
    {
        throw new NotImplementedException();
    }

    //TODO
    private static int pb19()
    {
        throw new NotImplementedException();
    }

    //TODO
    private static string pb18()
    {
        throw new NotImplementedException();
    }
    private static string pb17()
    {
        string ans = "";
        int n, b;
        Console.WriteLine("Scrie numarul in baza 10: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Scrie baza in care trebuie sa fie convertit numarul: ");
        b = int.Parse(Console.ReadLine());

        while (n != 0)
        {
            //luam restul impartirii ca sa aflam cifra in baza b
            int cifraCurenta = n % b;
            char chifraChar = (cifraCurenta < 10) ? (char)(cifraCurenta + '0') : (char)(cifraCurenta - 10 + 'A');
            ans = cifraCurenta + ans;
            n /= b;
        }
        return ans;
    }

    private static int cmmdc(int x, int y){
        while (x != y)
        {
            if (x > y)
            {
                y -= x;
            } else
            {
                x-= y;
            }
        }
        return x;
    }
    private static int pb16()
    {
        int[] v = new int[1000];
        int n;
        int x, div = 0;
        Console.WriteLine("Scrie numarul n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Scrie numarul de pe pozitia {0}: ", i);
            x = int.Parse(Console.ReadLine());
            v[i] = x;
        }
        int prevDiv = 0;
        for(int i = 1; i < n; i++)
        {
            if (i == 1)
            {
                prevDiv = cmmdc(v[i-1], v[i]);
                div = prevDiv;
            }
            else
            {
                div = cmmdc(prevDiv, v[i]);
                prevDiv = div;
            }
        }
        return div;
    }

    private static string pb15()
    {
        int[] v = new int[1000];
        int n;
        int x;
        string ans = "";
        Console.WriteLine("Scrie numarul n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Scrie numarul de pe pozitia {0}: ", i);
            x = int.Parse(Console.ReadLine());
            v[i] = x;
        }

        //Sortam vectorul cu metoda selection sort
        int j;
        for (int i = 0; i < n - 1; i++)
        {
            for (j = i + 1; j < n; j++)
            {
                if (v[j] < v[i])
                {
                    int aux = v[i];
                    v[i] = v[j];
                    v[j] = aux;
                }
            }
        }

        //pointer care o sa ne ajute sa gasim elementele care se repeta
        j = 0;

        //parcurgem vectorul
        for (int i = 1; i< n; i++)
        {
            if (v[j] != v[i])
            {
                j++;
                v[j] = v[i];
            }
        }

        for (int i = 0; i < j; i++)
        {
            ans += v[i] + ", ";
        }
        return ans.Substring(0, ans.Length - 2);
    }

    private static string pb14()
    {
        int[] v = new int[1000];
        int n;
        int x;
        string ans = "";
        Console.WriteLine("Scrie numarul n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Scrie numarul de pe pozitia {0}: ", i);
            x = int.Parse(Console.ReadLine());
            v[i] = x;
        }

        //doi pointeri care ne ajuta sa face o singura parcurgere
        int st = 0, dr = n - 1;
        while(st < dr)
        {
            //daca elementul primului pointer este diferit de 0 incrementam valoarea pointerului
            if(v[st] != 0)
            {
                st++;
            }

            //daca elementul celui de-al doilea pointer este 0 decrementam valoarea pointerului
            if (v[dr] == 0)
            {
                dr--;
            }

            //interschimbam valorile
            if (v[st] == 0 && v[dr] != 0)
            {
                int temp = v[st];
                v[st] = v[dr];
                v[dr] = temp;
            }
        }
        for (int i = 0; i < n; i++)
        {
            ans += v[i] + ", ";
        }
        return ans.Substring(0, ans.Length - 2);
    }

    private static string pb13()
    {
        int[] v = new int[1000];
        int n;
        int x;
        string ans = "";
        Console.WriteLine("Scrie numarul n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Scrie numarul de pe pozitia {0}: ", i);
            x = int.Parse(Console.ReadLine());
            v[i] = x;
        }

        //Insertion sort
        for (int i = 1; i < n; i++)
        {
            int p = i;
            while(p>0 && v[p] < v[p - 1])
            {
                int aux = v[p];
                v[p] = v[p - 1];
                v[p - 1] = aux;
                p--;
            }
        }

        for (int i = 0; i < n; i++)
        {
            ans += v[i] + ", ";
        }
        return ans.Substring(0, ans.Length - 2);
    }

    private static string pb12()
    {
        int[] v = new int[1000];
        int n;
        int x;
        string ans = "";
        Console.WriteLine("Scrie numarul n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Scrie numarul de pe pozitia {0}: ", i);
            x = int.Parse(Console.ReadLine());
            v[i] = x;
        }

        // Selection sort
        for(int i = 0; i < n - 1; i++)
        {
            for(int j = i+1; j<n; j++)
            {
                if (v[j] < v[i])
                {
                    int aux = v[i];
                    v[i] = v[j];
                    v[j] = aux;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            ans += v[i] + ", ";
        }
        return ans.Substring(0, ans.Length - 2);
    }

    private static int pb11()
    {
        int[] v = new int[1000];
        int n;
        int x, numarPrime = 0;
        int[] ciur = new int[1000000];
        ciur[0] = 1;
        ciur[1] = 1;
        // calcularea ciurului ui Eratostene
        for(int i = 2; i < 1000; i++)
        {
            if (ciur[i] == 0)
            {
                for (int j = 2; j < 1000; j++)
                {
                   ciur[i*j] = 1;
                }
            }
        }
        Console.WriteLine("Scrie numarul n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Scrie numarul de pe pozitia {0}: ", i);
            x = int.Parse(Console.ReadLine());
            v[i] = x;
        }

        for(int i = 0; i<n; i++)
        {
            if (ciur[v[i]] == 0)
            {
                numarPrime++;
            }
        }
        return numarPrime;
    }
    private static int pb10()
    {
        int[] v = new int[1000];
        int n;
        int x, k;
        Console.WriteLine("Scrie numarul n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Scrie numarul de pe pozitia {0}: ", i);
            x = int.Parse(Console.ReadLine());
            v[i] = x;
        }
        Console.WriteLine("Scrie numarul k: ");
        k = int.Parse(Console.ReadLine());
        int st = 0, dr = n - 1;
        while (st != dr)
        {
            int mid = (st + dr) / 2;
            if (v[mid] < k)
            {
                st = mid + 1;
            }
            else if(v[mid] > k)
            {
                dr = mid;
            }
            else {
                return mid;
            }
        }

        return -1;
    }

    //TODO
    private static string pb9()
    {
        int[] v = new int[1000];
        int n;
        int x, k;
        string ans = "";
        Console.WriteLine("Scrie numarul n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Scrie numarul de pe pozitia {0}: ", i);
            x = int.Parse(Console.ReadLine());
            v[i] = x;
        }
        Console.WriteLine("Scrie numarul de pozitii: ");
        k = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            ans += v[i] + ", ";
        }
        throw new NotImplementedException();
    }

    private static string pb8()
    {
        int[] v = new int[1000];
        int n;
        int x;
        string ans = "";
        Console.WriteLine("Scrie numarul n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Scrie numarul de pe pozitia {0}: ", i);
            x = int.Parse(Console.ReadLine());
            v[i] = x;
        }
        for(int i = 0; i<n-1; i++)
        {
            int aux = v[i];
            v[i] = v[i+1];
            v[i+1] = aux;
        }
        for (int i = 0; i < n; i++)
        {
            ans += v[i] + ", ";
        }
        return ans.Substring(0, ans.Length - 2);
    }

    private static string pb7()
    {
        int[] v = new int[1000];
        int n;
        int x;
        string ans = "";
        Console.WriteLine("Scrie numarul n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Scrie numarul de pe pozitia {0}: ", i);
            x = int.Parse(Console.ReadLine());
            v[i] = x;
        }
        for(int i = 0; i<(n/2); i++)
        {
            v[i] += v[n - i - 1];
            v[n - i - 1] = v[i] - v[n - i - 1];
            v[i] = v[i] - v[n - i - 1];
        }

        for(int i = 0; i<n; i++)
        {
            ans += v[i] + ", ";
        }
        return ans.Substring(0, ans.Length - 2);
    }

    private static string pb6()
    {
        int[] v = new int[1000];
        int n;
        int x, k;
        string ans = "";
        Console.WriteLine("Scrie numarul n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Scrie numarul de pe pozitia {0}: ", i);
            x = int.Parse(Console.ReadLine());
            v[i] = x;
        }
        Console.WriteLine("Scrie pozitia:");
        k = int.Parse(Console.ReadLine());
        for(int i = k; i<n-1; i++)
        {
            v[i] = v[i + 1];
        }
        n--;
        for(int i = 0; i < n; i++)
        {
            ans += v[i] + ", ";
        }
        return ans.Substring(0, ans.Length - 2);
    }
    private static string pb5()
    {
        int[] v = new int[1000];
        int n;
        int x,e,k;
        string ans = "";
        Console.WriteLine("Scrie numarul n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Scrie numarul de pe pozitia {0}: ", i);
            x = int.Parse(Console.ReadLine());
            v[i] = x;
        }
        Console.WriteLine("Scrie numarul e:");
        e = int.Parse(Console.ReadLine());
        Console.WriteLine("Scrie pozitia:");
        k = int.Parse(Console.ReadLine());

        for(int i = n; i>=k; i--)
        {
            v[i] = v[i - 1];
        }
        v[k] = e;
        n++;
        for(int i = 0; i<n; i++)
        {
            ans += v[i] + ", ";
        }
        return ans.Substring(0, ans.Length-2);
    }

    private static string pb4()
    {
        int[] v = new int[1000];
        int n;
        int x, min = int.MaxValue, max = int.MinValue, fmin=0, fmax=0;
        Console.WriteLine("Scrie numarul n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Scrie numarul de pe pozitia {0}: ", i);
            x = int.Parse(Console.ReadLine());
            v[i] = x;
        }
        for (int i = 0; i < n; i++)
        {
            if(min > v[i])
            {
                min = v[i];
                fmin = 1;
            } else if(min == v[i])
            {
                fmin++;
            }
            if (max < v[i])
            {
                max = v[i];
                fmax = 1;
            }
            else if (max == v[i])
            {
                fmax++;
            }
        }
        return String.Concat("Minim: ", min, ", Frecventa minim:", fmin, ", Maxim: ", max, ", Frecventa maxim: ", fmax);
    }

    private static string pb3()
    {
        int[] v = new int[1000];
        string ans ="";
        int n;
        int x,min=int.MaxValue,max=int.MinValue;
        Console.WriteLine("Scrie numarul n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Scrie numarul de pe pozitia {0}: ", i);
            x = int.Parse(Console.ReadLine());
            if(x < min)
            {
                min = x;
            }
            if(x > max)
            {
                max = x;
            }
            v[i] = x;
        }
        int k = 0;
        ans = "Pozitii: ";
        for (int i = 0; i < n; i++)
        {
            if(v[i] == min || v[i] == max)
            {
                ans += i + ",";
            }
        }

        return ans.Substring(0,ans.Length-1);
    }

    private static int pb2()
    {
        int[] v = new int[1000];
        int n ,k;
        int x;
        Console.WriteLine("Scrie numarul n: ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Scrie numarul de pe pozitia {0}: ", i);
            x = int.Parse(Console.ReadLine());
            v[i] = x;
        }
        Console.WriteLine("Scrie numarul k: ");
        k = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            if (v[i] == k)
            {
                return i;
            }
        }

        return -1;
    }

    private static int pb1()
    {
        int[] v = new int[1000];
        int n;
        int x,s=0;
        Console.WriteLine("Scrie numarul n: ");
        n = int.Parse(Console.ReadLine());
        //citire vector
        for(int i = 0; i<n; i++)
        {
            Console.WriteLine("Scrie numarul de pe pozitia {0}: ", i);
            x = int.Parse(Console.ReadLine());
            v[i]=x;
        }
        //parcurgere vector
        for (int i = 0; i < n; i++)
        {
            s += v[i];
        }
        return s;
    }
}