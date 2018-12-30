using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class Day_1
    {
        public static void First()
        {
            var inputs = frequencyInput_first.Split('\n');
            var partials = new List<long>();
            long frequency = 0;
            partials.Add(frequency);
            foreach (var line in inputs)
            {
                frequency += long.Parse(line);
            }
            Console.WriteLine($"Resulting frequency is {frequency}");
        }

        public static void Second()
        {
            var inputs = frequencyInput_first.Split('\n');
            var partials = new List<long>();
            long frequency = 0;
            partials.Add(frequency);
            while (true)
            {
                foreach (var line in inputs)
                {
                    frequency += long.Parse(line);
                    if (partials.Contains(frequency))
                    {
                        Console.WriteLine($"Frequency repeated {frequency}");
                        return;
                    }
                    partials.Add(frequency);
                }
                Console.WriteLine("Did not repeat..");
            }
        }

        static string frequencyInput_first = @"-17
+14
+10
-2
-1
+6
+6
+7
+1
+9
+8
-13
-7
+17
-4
-16
-6
-11
-7
-20
+3
+2
-10
-5
+3
+5
+13
-3
-2
-4
+19
-6
+14
-4
+3
+6
+17
+4
-18
+16
+19
-3
-4
+18
-2
+7
-10
-8
+10
-6
+11
+5
-6
+14
-16
-5
+15
+2
+14
-19
+13
+1
-6
-18
+20
+16
-10
+8
-9
+3
+9
+16
-9
-3
-6
+5
+15
-1
+12
-7
-2
-14
+20
-11
+24
-12
+1
-5
+7
+14
+8
-16
-17
-24
+17
+1
+8
-12
+1
-8
-12
-10
+16
-3
-16
-7
+14
-13
-19
+8
-1
-4
-13
-2
+10
-4
-17
-23
+21
+18
-20
+16
-22
-16
-6
-16
-6
+5
+5
-19
-18
+14
-10
-15
+4
+19
-11
-15
+16
-17
-8
-15
+12
-17
+3
-13
+3
+3
-8
-15
-14
+11
+13
-3
-4
+9
+21
-9
+12
-2
+6
+6
+8
-2
+16
-6
+4
-1
+15
+1
+4
+6
-14
+2
-19
-18
+6
-3
+5
+8
-19
-4
-17
-16
-13
-16
+5
-6
-2
+7
-13
-8
-13
-19
+5
+12
-13
+19
-2
+16
+4
+18
+9
-1
-4
-16
+19
+19
+4
-5
-14
+12
-7
-1
-24
-8
-9
-18
-16
+2
-13
-7
+16
-7
+4
-12
-9
-10
+14
+18
-16
+6
+17
-6
+10
+5
+5
+10
+5
-13
-9
-1
+2
+12
-15
+6
+7
+14
+11
-7
+13
+10
+19
+17
+7
+10
-9
-10
+12
-9
+21
+26
+18
-11
-1
-11
+22
+12
-3
-5
-17
+16
+3
+24
+14
+8
+20
-6
-7
-22
+1
-2
+24
+23
-15
+25
+37
-15
+6
+40
+13
+3
+8
-18
+6
-4
+13
+18
-4
+5
-11
+4
+14
-16
+5
-11
-15
+7
+1
+4
+21
+18
+15
-18
-9
-8
+18
-4
+9
+18
-12
+1
+14
-8
+1
-11
-15
+8
+6
-20
-4
+12
-1
-3
-13
-17
+8
+20
-10
+30
+12
-7
-1
-15
+12
-4
+18
-8
+16
+4
+13
-8
-11
-5
+18
+8
+17
+14
-16
+6
+12
+5
+19
+2
+13
-19
+8
+3
-16
-20
+16
+5
-13
-14
-11
+14
+14
-5
+16
+5
+8
+13
-16
-18
-1
+15
-11
-10
-19
-10
-7
-4
+7
-11
-2
+21
-7
+5
-15
-17
-7
+18
-5
+12
+3
+8
+15
-7
-17
+18
-10
+5
+17
-8
+1
-18
-18
-6
-13
-18
+6
-11
-19
-2
-15
-8
-18
-3
-6
+3
+26
+14
+11
+10
+46
+4
+4
-2
+21
+22
+14
+8
-4
+20
-2
+4
+23
+11
+22
+16
-8
+11
+22
-17
+4
-8
-13
-15
+11
+19
-23
-5
-5
+47
+9
-12
+18
+15
+15
+8
+8
+37
-1
-15
-17
-10
+32
+22
+15
-10
+8
+128
+27
+19
+18
+18
+7
+34
+18
+10
-3
-5
+22
+4
+15
+2
+3
+9
-6
-35
-22
-1
+4
+55
-2
+80
+21
-2
+53
+33
+13
-60
-28
-44
-30
+2
-17
+12
+249
+26
-186
+72428
-2
+13
+17
+15
-18
+1
+7
+3
-14
+1
-4
-2
+3
-18
+2
+14
-13
-8
-21
-4
-2
-8
-5
+18
+12
-9
+2
+13
+6
-9
+17
+9
+8
+14
-3
+7
-3
+16
-15
+10
+18
+12
-9
+12
+7
+18
-17
+1
+14
+9
-1
+8
+13
-4
-12
-8
+10
+6
+2
+8
+2
+6
+16
-20
+10
+2
+19
-6
-14
+17
+6
+7
+3
+4
+19
+16
+17
+1
+1
+4
+19
-12
+2
+12
-6
+11
+16
-1
+10
-3
+15
+17
+2
+7
+9
-14
+16
+15
+13
+10
-12
-8
+13
+1
-11
-10
-19
+16
+2
-8
+4
-20
-18
+19
+7
+15
+11
+17
+7
-14
+6
-12
-19
-8
+6
-4
+8
+6
+3
+17
+8
+16
-1
+4
-18
+3
-10
+5
+15
-4
+8
-1
-11
-8
+14
+17
+6
-12
+17
-13
+9
-5
+19
+10
-19
+17
+13
+12
-4
-2
-11
+14
+14
+17
+12
-15
-10
-13
+2
-18
-17
+13
-1
-2
+6
-9
+13
+10
+8
+11
+14
-15
-16
-11
-18
-9
+10
-12
+4
-3
+12
+13
-28
-4
+16
+20
+12
+19
+14
-17
+11
+15
+12
-18
-2
+6
+17
+21
-22
-17
-18
-19
+4
+3
+2
+2
-6
-15
-25
-4
-12
-12
-12
+21
-12
+6
-4
-3
-10
-9
-16
-13
-19
-17
-2
-15
+9
+15
+3
-17
+10
-9
-16
+9
+9
+1
+4
-12
+6
+18
-29
-8
-16
-16
+10
-14
-4
+6
+15
+5
+7
+12
-4
-18
-10
-19
+17
-21
-2
-16
-18
-15
+13
-12
-18
-6
-3
-19
-13
-14
+10
-14
+12
-3
-17
-14
-18
-15
+4
-15
+19
-10
+3
-18
+2
+2
-9
+13
+6
-13
+6
-22
-23
-19
+18
+19
+16
-21
+18
+18
+13
-11
+7
+21
-11
+15
-1
+9
-4
-12
+15
-19
-10
+3
+1
+24
+14
+6
+17
+19
+9
+11
-12
-10
+8
+16
+13
-18
+2
+10
+16
+17
+6
+4
-1
+4
+5
+9
+4
-15
-1
+23
+21
+6
-15
-11
+10
-17
+11
+14
-2
+1
+19
-15
+18
-6
-18
+17
+13
+6
+2
+17
-23
-16
-8
+21
+62
-15
-8
+5
+24
+36
+10
+2
+19
-8
+18
+2
+13
-1
-8
+14
+35
+21
+7
-14
+19
-3
+39
+11
+12
+25
-5
-6
-7
+14
+15
+22
-19
+12
-18
+19
-17
-9
-13
+11
+45
+21
-18
+12
-14
+26
+10
+4
+9
-1
+3
+14
+5
-2
+7
-14
-2
-12
+25
+19
+3
+7
-28
-6
+15
+3
+11
+10
-22
-6
-2
+3
+21
+14
-12
+17
-6
-32
-28
+2
+19
-16
+8
-4
-20
+1
+3
+17
-36
-21
-3
+2
+14
-29
+20
-6
+25
-11
+34
-76
+10
+30
-42
-32
-25
-12
+8
+7
-35
+17
-5
-10
+3
+10
-23
-37
-15
+14
+18
-88
-38
+17
+13
+50
-56
-25
-26
-1
-29
+19
-73214";

    }

    public class Day_2
    {
        private static IEnumerable<int> CalculateLetterFrequencies(string ID)
        {
            var freqs = new Dictionary<char, int>();
            foreach (var c in ID)
            {
                int v = 0;
                freqs.TryGetValue(c, out v);
                freqs[c] = v + 1;
            }
            int[] ret = new int[freqs.Values.Count];
            freqs.Values.CopyTo(ret, 0);
            return ret;
        }

        private static string FindKeyIfMatch(string a, string b)
        {
            var diff = a.Length;
            for (var i = a.Length - 1; i >= 0; i--)
            {
                if (a[i] == b[i]) diff--;
            }

            if (diff == 1)
            {
                var result = "";
                for (var i = 0; i < a.Length; i++)
                {
                    if (a[i] == b[i])
                        result += a[i];
                }
                return result;
            }
            return null;
        }

        public static void First()
        {
            var IDs = IDs_second.Split(new[] { "\r\n" }, StringSplitOptions.None);
            var twos = 0;
            var threes = 0;
            foreach (var ID in IDs)
            {
                var f = CalculateLetterFrequencies(ID);
                if (f.Where(i => i == 2).Any()) twos++;
                if (f.Where(i => i == 3).Any()) threes++;
            }
            Console.WriteLine($"{twos} * {threes} = {twos * threes}");
        }

        public static void Second()
        {
            var IDs = IDs_second.Split(new[] { "\r\n" }, StringSplitOptions.None);
            for (var idx = 0; idx < IDs.Length; idx++)
            {
                for (var idy = 0; idy < IDs.Length; idy++)
                {
                    if (idy != idx)
                    {
                        var result = FindKeyIfMatch(IDs[idx], IDs[idy]);
                        if (result != null)
                        {
                            Console.WriteLine($"The common letters are: {result} ({result.Length} of { IDs[idx].Length} chars match)");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("No solution found");
        }

        private static string IDs_second = @"luojygedpvsthptkxiwnaorzmq
lucjqgedppsbhftkxiwnaorlmq
lucjmgefpvsbhftkxiwnaorziq
lucjvgedpvsbxftkxiwpaorzmq
lrcjygedjvmbhftkxiwnaorzmq
lucjygedpvsbhftkxiwnootzmu
eucjygedpvsbhftbxiwnaorzfq
lulnygedpvsbhftkxrwnaorzmq
lucsygedpvsohftkxqwnaorzmq
lucjyaedpvsnhftkxiwnaorzyq
lunjygedpvsohftkxiwnaorzmb
lucjxgedpvsbhrtkxiwnamrzmq
lucjygevpvsbhftkxcwnaorzma
lucjbgedpvsbhftrxiwnaoazmq
llcjygkdpvhbhftkxiwnaorzmq
lmcjygxdpvsbhftkxswnaorzmq
lucpygedpvsbhftkxiwraorzmc
lucjbgrdpvsblftkxiwnaorzmq
lucjfgedpvsbhftkxiwnaurzmv
lucjygenpvsbhytkxiwnaorgmq
luqjyredsvsbhftkxiwnaorzmq
lucjygedpvavhftkxiwnaorumq
gucjygedpvsbhkxkxiwnaorzmq
lucjygedpvsbhftkxlwnaordcq
lucjygedpvibhfqkxiwnaorzmm
lucjegedpvsbaftkxewnaorzmq
kucjygeqpvsbhfokxiwnaorzmq
lugjygedwvsbhftkxiwnatrzmq
lucjygedqvsbhftdxiwnayrzmq
lucjygekpvsbuftkxiwnaqrzmq
lucjygedpvsbhfbkxiwnaoozdq
lscjygedpvzchftkxiwnaorzmq
luckygedpvsbxftkxiwnaorvmq
luyjygedgvsbhptkxiwnaorzmq
lmcjygedpvsbhfckxiwnaodzmq
lucmygedwvybhftkxiwnaorzmq
lgcjhgedavsbhftkxiwnaorzmq
lucjugedpvsbhftkxiwmaoozmq
lucjygedpvybhftkxkwnaorumq
lucjygedpvzbhfakxiwnaorzpq
lucjygedpvsbhftyxzwnajrzmq
lucjygedpvsdhfakxiwnoorzmq
luyjygeopvhbhftkxiwnaorzmq
lucjygadpvsbhntkxiwnaorzmx
lucjygedzvsbhftkiiwuaorzmq
sucjygodpvsbhftkxiwuaorzmq
euijygydpvsbhftkxiwnaorzmq
lucjlgeduvsbhftkxicnaorzmq
lucjdgedpvsbhfgkxiwnhorzmq
lucjymedpvsbhotkxiqnaorzmq
lucjygmdpvsbhftkxywnairzmq
lucjggedpvsbhfxkxiqnaorzmq
sucjygedpvsbhftkxiwnaorjmv
lucjlgedpvsbhftkxiwnairzmg
lucjygedppubhftkxijnaorzmq
lucjyxedpvsvhftkxlwnaorzmq
lucjygedpvxbhftkfiwyaorzmq
lucjygedposbhftkniwnaorzmw
lucjygewpvsbhftgxiwnavrzmq
lucjynedpvsbmftkaiwnaorzmq
lucjyhedpvzbhftkxiwncorzmq
lucjygedpvsbhfikpiwnaoezmq
lupjypedpvsbhftkjiwnaorzmq
lucjygudpvsbhfwkxivnaorzmq
lucjygrdpvsbhatkxzwnaorzmq
lucjbgmdpvsbhftkxihnaorzmq
lucjmgedpvpbhftkxiwnaorcmq
lucjygedpvskhfukmiwnaorzmq
lucjygedgvsbhftkxiwnvprzmq
lucjzgedppsbhytkxiwnaorzmq
lfcjypedpvsbhftrxiwnaorzmq
lucjyqldphsbhftkxiwnaorzmq
lucjygedpvsbhftzxewnaorzqq
lucjygeapvsbhftkxiinoorzmq
lucjygedpvszhftguiwnaorzmq
luojygedpvsbhftkxawnaornmq
lucjygedpcsboetkxiwnaorzmq
lufjygedpvfbhftaxiwnaorzmq
luciygedpvsbhftkxhwaaorzmq
lucjygedpvnbhftkaiwnaorzmc
lucjygedpvsbhftkxiwcaorbdq
lucjygelpvsbhftaxiwsaorzmq
lujjygedpssbhftkxiwnaorzmr
ludjygedpvsbhftkxiynaorzmj
lukjygeedvsbhftkxiwnaorzmq
lucjqpedpvsbhftkxiwnaozzmq
jucjygedpvsbhftkxgwnaorqmq
llwjygedpvsbhetkxiwnaorzmq
rucjygedpvsbhftkxiwndorymq
lucjygedpvsbhftvxswnaorwmq
lucjygerpvsbhfykxiwnaormmq
lucjynedpvsbhftkxijnaorziq
ljcjygedpvrbhftkeiwnaorzmq
lucjygedpnsbhftkxiwhaornmq
lucjygadpvsbhftkxibnaorzqq
lucjqgedpvsihftkxiwnaorzdq
lucjygedpvsqhfttjiwnaorzmq
llcjygedsvsbhftkxiwwaorzmq
lfckygedpvsbhftkxiunaorzmq
lucjyeedpdsbhftkxiwnaotzmq
lucjygedpvsbhftkoiwnaoqzcq
huwjvgedpvsbhftkxiwnaorzmq
lucjygldpvsbdhtkxiwnaorzmq
lycxygedpvsbhftmxiwnaorzmq
lucjygedpvsbhftyxianvorzmq
lucuygedpdsbhqtkxiwnaorzmq
lucjyggdpvsbhftkxiwnavremq
lucjyggdpvsbkftkxiwnaorbmq
luchyqedpvsbhftixiwnaorzmq
lpcnygedpvsbhftkxzwnaorzmq
lucjygedpvsihftkxiwfaortmq
lucjygvdpvsbhgtkxiwnamrzmq
lucjygodpvrbhqtkxiwnaorzmq
lucjygedpfsbhftkxipnaorzma
lucjygedpvsbhftkxpcjaorzmq
lucjygodbmsbhftkxiwnaorzmq
lucjygedpvsbhftkxipnaogzmb
luxjygjdpvsbhltkxiwnaorzmq
lucxygedpvsbhftkxzwnaorjmq
luajygedpvsbhftzxiwaaorzmq
lhcjygedpvsqhftfxiwnaorzmq
lucjygecphsbhftkxiwnaprzmq
lucjygedpvsbhptkxifnaorqmq
lucjygedpvichftkpiwnaorzmq
lucjygedpcsbhstkxswnaorzmq
kucjygedpvsbhftkxiwbyorzmq
lfpjxgedpvsbhftkxiwnaorzmq
lucjytldpvsbhftkxiwdaorzmq
lufjygedpvfbhftbxiwnaorzmq
lucjygebpvgbhftkxipnaorzmq
luujygedpvdbhftkxiwnaorzmd
lucjygedpvsbhfbyxwwnaorzmq
lucjygedpvsbhftkxiwnaoqpmw
qucgygedpvsbhftkxiwnaortmq
ludjtgedpvsbhftkxiunaorzmq
lucjyiedovsbhftkxiwjaorzmq
lucjygedpysbjftoxiwnaorzmq
lumjygedpvsbuftkxiknaorzmq
lucjygedpvsbhfokxgonaorzmq
lucjygeqpvsbhftkfiwnaorzeq
lucjygedpvskhftkxiwntorkmq
luujygedpvsbhftkxiwraorzmt
lucwygedpvsbjftkxiwnaorzmj
jucjyfedcvsbhftkxiwnaorzmq
luujygedpnsehftkxiwnaorzmq
lucjygedpvszhfckxiwnaorzmi
lucjyredpvsbzftkpiwnaorzmq
lucjygedpvsbwfgkxiwnaorzoq
lucjygedpvgbhftkpiwnaorzms
lucjygedpvjbhftkxzwnaoizmq
vucjycedpvsbhftkxiwfaorzmq
luawygeapvsbhftkxiwnaorzmq
lucjygetpvsbhftkxiwnaafzmq
lucjvgedpvsbhftkxywnavrzmq
luolygedpvsbgftkxiwnaorzmq
likjygedpvsbhftkxiwnabrzmq
lucjygedovsbhftkxirpaorzmq
lucjygedphsshftkxqwnaorzmq
uuqjygewpvsbhftkxiwnaorzmq
lucjygedcvsbhftkxiwoarrzmq
lucnygedpvsbhfakxiwnaorzms
lucjygedpvsbhntkxiwnawrzmb
lucjygedpvsblfxkxivnaorzmq
lucjygedpvsghftkxiwnaawzmq
yucjygedpgsbhftkxiwnaorzbq
lucjyweapvsbhftkxiwnaoezmq
lucjygevpvsbyftcxiwnaorzmq
luejygedovsbhftkxiwnqorzmq
lucjyqedpvsbhfbkxiwnaorzms
lucjypedpvsbhftwxiwnhorzmq
lucjygedpvsbhmtkviwxaorzmq
lucjogedpvpbhftkxiwnaorqmq
lucjygedpvsbhztkxkwnaoazmq
lucjyaedpvsbcftkxiwnaorzhq
lucjygbdpvkbhftkxiznaorzmq
lucpygedpvzbhftkxfwnaorzmq
lucjmgedpcsbhftkxiwnaoezmq
lucjygedyvsbbftkxiwnnorzmq
lucjyyedpvsbhftuxiwnaonzmq
lucjygfdpvsbhutkxiwnaorzmt
uccjygedpvschftkxiwnaorzmq
lusjygedpvbbhqtkxiwnaorzmq
ducuygedpvsbhftkxiwnaorzyq
lucjygkdvwsbhftkxiwnaorzmq
cucjyyedpvsbhftkxiwnaerzmq
lucjygedavsbhftkxiwnkorzbq
lucjygedmvsyhftkxiwiaorzmq
lucjygeipvsbhfpkxiwnaorzpq
vucjugedvvsbhftkxiwnaorzmq
lucjyzedpvsbhftkxpwnaoozmq
lucjygedpvgbhftkxiwtaorzqq
lecjygedpvcwhftkxiwnaorzmq
lucjyghdpvsbhfcyxiwnaorzmq
lucjygedpvesqftkxiwnaorzmq
lucjyjehpvsbhftbxiwnaorzmq
lucjygedpvtbhdtkxignaorzmq
lucjygxdpgsbhftkxivnaorzmq
lucjygvdpvsbhftkpiwnaorzqq
lucjysedpvsbhftkxiwnalrzmc
lucjygedpvkbhjtkxiwnaorsmq
lucjygedpvsbvfgkxiwnaerzmq
lucjygedpvsihftkxilnaorzmu
lvcvygndpvsbhftkxiwnaorzmq
lucjysedpqsbhftkxiwnaordmq
lucsygeypvsbhftkwiwnaorzmq
lucjygewpotbhftkxiwnaorzmq
lucjysedpvsbhftkxiwnanrzmv
lucjygedpvsbhutkxiwnaoplmq
wucjygedpvsqbftkxiwnaorzmq
lacjygeepvsbhftkxiwnjorzmq
lucjygedpusyhftkxicnaorzmq
qucjyredpvsbhftkxiwnworzmq
lucjygedevsbhftkgiwnayrzmq
lucjygedpksbrftkliwnaorzmq
lucjygedpvsbhfgkxisnaorzeq
lucjygedpvhdhftkeiwnaorzmq
lucjsgedpvsboftkxiwnaorumq
luctygedpvsbhftouiwnaorzmq
lucjygedpvsjhfukjiwnaorzmq
lucjagrepvsbhftkxiwnaorzmq
lucjkgerpvsbhftkxiwnairzmq
turjygedpvsbnftkxiwnaorzmq
lbcjygedpvsbhftkdpwnaorzmq
lucpygedpvsbhftkxnwnoorzmq
jucjygedpvsbhbtkxicnaorzmq
lecjygedpvsbhftkriwnaogzmq
licjyvcdpvsbhftkxiwnaorzmq
lrcjygewpnsbhftkxiwnaorzmq
ltcxygedpvlbhftkxiwnaorzmq
luctygedpvhbhztkxiwnaorzmq
lucwygedplsbhfakxiwnaorzmq
lucjygedpnsbhftkxiwjaoezmq
lucpygedptsbhftkxiwnaorzmo
lucjygedpvibhqtkxiknaorzmq
lucjwgqdpvrbhftkxiwnaorzmq
lucjmgkdpvsbhftkxiwraorzmq
lucjygwupvsbhftkxiznaorzmq
lucjhgedpvobhftkxiwncorzmq
lucjygedpvsbhftkxiwnaohtmj
lucjygedpvsbeftkfiwnaorzyq
lucjygcdpvsbpftkhiwnaorzmq
lucjygedpmsbhftkxiwnkouzmq
oucjygedpvsbyftkximnaorzmq
lucjcgedpvsbhftkxywnforzmq
lfcjygedfvsbdftkxiwnaorzmq
ducjygedevsbhfttxiwnaorzmq
ldcjdgedpvsbhftkxiwnavrzmq
lucjymedmvsbhqtkxiwnaorzmq
lucjygedpvabhftkxiwnasrlmq
lucjygefpvsbhftkxmwnaorkmq";

    }

    public class Day_3
    {
        class Claim
        {
            public int claimId;
            public int x;
            public int y;
            public int sizeX;
            public int sizeY;
        }

        private static Claim ParseClaim(string claimString)
        {
            var token = claimString.Split(' ');
            var startXY = token[2].Split(',');
            var sizeXY = token[3].Split('x');

            var claimId = int.Parse(token[0].Substring(1));
            var x = int.Parse(startXY[0]);
            var y = int.Parse(startXY[1].Substring(0, startXY[1].Length - 1));
            var sizeX = int.Parse(sizeXY[0]);
            var sizeY = int.Parse(sizeXY[1]);

            return new Claim()
            {
                claimId = claimId,
                x = x,
                y = y,
                sizeX = sizeX,
                sizeY = sizeY
            };

        }

        private enum ClaimStatus
                { NotClaimed= 0,
                  Claimed= 1,
                  ClaimedMulti =2};

        private static void MarkClaim(Claim c, ClaimStatus[,] fabric)
        {
            for(int i= c.y; i < c.y + c.sizeY; i++)
            {
                for (int j = c.x; j < c.x + c.sizeX; j++)
                {
                    fabric[i,j] = (fabric[i,j] == ClaimStatus.NotClaimed ? ClaimStatus.Claimed : ClaimStatus.ClaimedMulti);
                }
            }
        }

        private static bool CheckIfFreeClaim(Claim c, ClaimStatus[,] fabric)
        {
            for (int i = c.y; i < c.y + c.sizeY; i++)
            {
                for (int j = c.x; j < c.x + c.sizeX; j++)
                {
                    if (fabric[i, j] != ClaimStatus.Claimed)
                        return false;
                }
            }
            return true;
        }

        private static IEnumerable<Claim> BuildClaims()
        {
            var claims = fabricClaims.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            return claims.Select(ParseClaim);
        }


        public static void First()
        {
            var claims = BuildClaims();

            var sizeX = 1000;
            var sizeY = 1000;
            ClaimStatus[,] fabric = new ClaimStatus[sizeX, sizeY];
            foreach (var c in claims)
            {
                MarkClaim(c, fabric);
            }

            var claimCnt = 0;
            for (int i = 0; i < sizeY; i++)
            {
                for (int j = 0; j < sizeX; j++)
                {
                    if (fabric[j, i] == ClaimStatus.ClaimedMulti)
                        claimCnt++;
                }
            }

            Console.WriteLine($"{claimCnt} squares are claimed by more than one elf.");
        }



        public static void Second()
        {
            var claims = BuildClaims();

            var sizeX = 1000;
            var sizeY = 1000;
            ClaimStatus[,] fabric = new ClaimStatus[sizeX, sizeY];
            foreach (var c in claims)
            {
                MarkClaim(c, fabric);
            }

            foreach(var c in claims)
            {
                if (CheckIfFreeClaim(c, fabric))
                {
                    Console.WriteLine($"Claim {c.claimId} is not overlapping.");
                }
            }
        }


        private static string fabricClaims= @"#1 @ 257,829: 10x23
#2 @ 902,685: 10x20
#3 @ 107,733: 20x25
#4 @ 186,421: 20x11
#5 @ 360,229: 29x10
#6 @ 362,248: 24x10
#7 @ 922,250: 13x26
#8 @ 256,742: 18x14
#9 @ 344,569: 28x15
#10 @ 381,793: 13x16
#11 @ 456,936: 28x27
#12 @ 110,25: 21x13
#13 @ 974,739: 12x12
#14 @ 364,641: 17x7
#15 @ 223,935: 24x25
#16 @ 803,147: 20x17
#17 @ 928,694: 13x12
#18 @ 549,438: 13x29
#19 @ 836,706: 18x25
#20 @ 890,557: 25x18
#21 @ 790,671: 16x19
#22 @ 433,548: 22x20
#23 @ 341,291: 21x5
#24 @ 324,168: 12x21
#25 @ 696,677: 12x12
#26 @ 480,769: 16x25
#27 @ 966,125: 13x26
#28 @ 889,760: 18x26
#29 @ 708,275: 19x13
#30 @ 581,706: 25x12
#31 @ 334,387: 29x23
#32 @ 292,246: 29x22
#33 @ 299,500: 24x23
#34 @ 834,644: 28x27
#35 @ 510,172: 27x14
#36 @ 24,35: 27x15
#37 @ 801,484: 22x28
#38 @ 974,891: 22x26
#39 @ 633,281: 27x10
#40 @ 523,582: 19x28
#41 @ 417,878: 13x21
#42 @ 712,897: 12x27
#43 @ 899,927: 16x27
#44 @ 269,693: 16x28
#45 @ 42,356: 11x15
#46 @ 547,849: 24x27
#47 @ 706,394: 29x27
#48 @ 768,325: 10x27
#49 @ 289,823: 11x11
#50 @ 561,758: 4x3
#51 @ 193,226: 27x19
#52 @ 501,584: 21x25
#53 @ 481,898: 11x12
#54 @ 516,588: 23x29
#55 @ 2,952: 28x22
#56 @ 238,706: 14x23
#57 @ 28,782: 10x28
#58 @ 642,873: 28x20
#59 @ 853,310: 12x26
#60 @ 889,242: 21x20
#61 @ 351,305: 16x21
#62 @ 799,981: 10x13
#63 @ 276,590: 19x18
#64 @ 645,874: 21x24
#65 @ 276,886: 22x22
#66 @ 874,840: 24x10
#67 @ 700,653: 18x29
#68 @ 853,676: 21x13
#69 @ 763,53: 10x14
#70 @ 17,887: 11x15
#71 @ 876,860: 20x15
#72 @ 930,561: 11x11
#73 @ 299,467: 26x16
#74 @ 233,741: 29x13
#75 @ 388,776: 13x27
#76 @ 310,521: 29x25
#77 @ 644,963: 29x18
#78 @ 238,804: 13x25
#79 @ 8,767: 18x26
#80 @ 936,237: 27x12
#81 @ 866,607: 13x16
#82 @ 500,917: 20x15
#83 @ 176,579: 22x22
#84 @ 294,251: 19x12
#85 @ 500,169: 21x16
#86 @ 704,954: 14x11
#87 @ 890,741: 24x19
#88 @ 49,956: 21x25
#89 @ 544,270: 19x18
#90 @ 324,911: 29x26
#91 @ 100,615: 16x18
#92 @ 656,946: 25x21
#93 @ 537,169: 13x22
#94 @ 201,303: 22x22
#95 @ 579,753: 12x10
#96 @ 853,554: 23x27
#97 @ 393,731: 29x19
#98 @ 955,618: 24x10
#99 @ 79,64: 15x16
#100 @ 277,408: 26x27
#101 @ 770,263: 29x24
#102 @ 408,812: 18x10
#103 @ 907,612: 10x28
#104 @ 28,701: 20x16
#105 @ 290,821: 16x27
#106 @ 632,698: 17x20
#107 @ 901,513: 10x26
#108 @ 316,580: 14x22
#109 @ 501,383: 25x10
#110 @ 125,212: 28x19
#111 @ 296,379: 14x29
#112 @ 63,253: 21x11
#113 @ 234,490: 28x10
#114 @ 526,481: 12x29
#115 @ 963,620: 28x10
#116 @ 484,759: 14x13
#117 @ 831,423: 11x11
#118 @ 223,156: 16x22
#119 @ 842,698: 25x20
#120 @ 472,809: 24x28
#121 @ 118,488: 16x14
#122 @ 202,818: 18x23
#123 @ 633,564: 20x20
#124 @ 787,611: 20x22
#125 @ 687,49: 16x27
#126 @ 157,617: 26x10
#127 @ 349,266: 22x13
#128 @ 203,455: 15x14
#129 @ 747,335: 24x26
#130 @ 288,709: 24x16
#131 @ 256,565: 27x24
#132 @ 246,698: 14x11
#133 @ 403,860: 14x13
#134 @ 451,715: 14x18
#135 @ 956,933: 24x14
#136 @ 231,565: 17x29
#137 @ 597,138: 23x14
#138 @ 653,607: 27x15
#139 @ 560,977: 22x10
#140 @ 636,360: 13x20
#141 @ 931,520: 19x20
#142 @ 725,714: 23x24
#143 @ 881,852: 18x23
#144 @ 626,342: 15x23
#145 @ 521,338: 15x12
#146 @ 100,651: 18x11
#147 @ 498,172: 29x18
#148 @ 12,975: 22x24
#149 @ 516,783: 23x21
#150 @ 406,434: 28x20
#151 @ 25,598: 17x10
#152 @ 460,321: 14x29
#153 @ 667,324: 20x14
#154 @ 444,439: 28x17
#155 @ 275,388: 20x17
#156 @ 624,265: 14x17
#157 @ 892,770: 11x11
#158 @ 6,769: 16x19
#159 @ 621,733: 29x21
#160 @ 368,884: 24x16
#161 @ 108,167: 26x19
#162 @ 955,730: 11x12
#163 @ 639,717: 15x26
#164 @ 89,329: 20x28
#165 @ 183,616: 21x11
#166 @ 161,499: 27x29
#167 @ 506,934: 11x12
#168 @ 879,309: 13x10
#169 @ 562,663: 24x14
#170 @ 663,57: 27x14
#171 @ 746,43: 27x10
#172 @ 588,389: 11x14
#173 @ 516,953: 17x13
#174 @ 678,676: 13x25
#175 @ 869,624: 26x15
#176 @ 953,876: 24x22
#177 @ 328,743: 25x20
#178 @ 629,805: 21x24
#179 @ 650,601: 14x20
#180 @ 496,804: 29x28
#181 @ 281,54: 15x22
#182 @ 112,632: 13x21
#183 @ 206,399: 11x13
#184 @ 952,608: 20x15
#185 @ 27,279: 26x27
#186 @ 534,182: 17x26
#187 @ 924,720: 13x20
#188 @ 487,980: 12x11
#189 @ 793,171: 20x13
#190 @ 930,971: 17x10
#191 @ 824,947: 27x12
#192 @ 474,777: 29x11
#193 @ 655,830: 18x28
#194 @ 508,540: 21x12
#195 @ 85,70: 29x14
#196 @ 498,929: 19x16
#197 @ 267,394: 15x20
#198 @ 438,891: 13x24
#199 @ 372,433: 19x29
#200 @ 22,932: 16x6
#201 @ 835,568: 28x10
#202 @ 889,893: 15x22
#203 @ 534,181: 15x13
#204 @ 206,213: 10x22
#205 @ 947,764: 14x25
#206 @ 332,830: 28x26
#207 @ 664,677: 12x11
#208 @ 804,602: 12x11
#209 @ 385,483: 26x24
#210 @ 806,372: 12x15
#211 @ 880,841: 29x13
#212 @ 354,253: 24x26
#213 @ 367,695: 21x27
#214 @ 388,617: 28x22
#215 @ 292,112: 16x15
#216 @ 61,787: 25x17
#217 @ 428,862: 16x25
#218 @ 23,265: 17x11
#219 @ 717,960: 11x13
#220 @ 416,776: 20x24
#221 @ 29,230: 18x11
#222 @ 681,11: 24x25
#223 @ 930,517: 19x14
#224 @ 801,256: 15x12
#225 @ 218,948: 27x18
#226 @ 697,406: 23x27
#227 @ 201,761: 11x17
#228 @ 692,278: 17x17
#229 @ 454,330: 22x18
#230 @ 161,743: 11x7
#231 @ 51,213: 15x25
#232 @ 182,979: 15x13
#233 @ 737,0: 27x18
#234 @ 404,631: 21x29
#235 @ 263,356: 26x27
#236 @ 24,799: 29x16
#237 @ 881,328: 10x12
#238 @ 960,759: 8x7
#239 @ 12,987: 26x12
#240 @ 642,886: 18x28
#241 @ 180,817: 26x20
#242 @ 824,428: 13x11
#243 @ 204,784: 11x27
#244 @ 495,789: 10x18
#245 @ 96,826: 14x24
#246 @ 758,677: 16x22
#247 @ 935,834: 12x26
#248 @ 151,741: 26x12
#249 @ 554,595: 26x14
#250 @ 623,284: 19x10
#251 @ 574,255: 16x10
#252 @ 886,881: 13x16
#253 @ 476,0: 17x11
#254 @ 805,100: 12x16
#255 @ 383,500: 23x26
#256 @ 155,452: 15x12
#257 @ 310,694: 28x28
#258 @ 518,788: 17x10
#259 @ 897,862: 13x16
#260 @ 269,395: 26x15
#261 @ 766,978: 10x22
#262 @ 935,962: 19x23
#263 @ 700,282: 25x23
#264 @ 342,6: 20x24
#265 @ 818,661: 27x29
#266 @ 816,809: 23x28
#267 @ 813,848: 11x12
#268 @ 112,285: 10x24
#269 @ 38,272: 16x18
#270 @ 277,361: 16x10
#271 @ 421,687: 17x11
#272 @ 942,827: 12x12
#273 @ 331,913: 15x19
#274 @ 880,218: 25x21
#275 @ 655,587: 24x27
#276 @ 537,739: 13x12
#277 @ 759,812: 13x29
#278 @ 926,238: 15x25
#279 @ 229,482: 15x21
#280 @ 917,772: 21x27
#281 @ 390,706: 3x18
#282 @ 972,703: 14x16
#283 @ 412,614: 7x4
#284 @ 583,135: 12x28
#285 @ 516,908: 27x17
#286 @ 20,930: 22x12
#287 @ 318,394: 25x12
#288 @ 677,665: 29x29
#289 @ 345,404: 15x11
#290 @ 83,48: 26x28
#291 @ 298,125: 22x19
#292 @ 509,929: 28x17
#293 @ 549,927: 27x13
#294 @ 801,644: 22x22
#295 @ 552,560: 24x24
#296 @ 809,100: 16x23
#297 @ 105,686: 12x20
#298 @ 620,612: 15x17
#299 @ 739,707: 13x13
#300 @ 853,627: 24x21
#301 @ 244,149: 21x27
#302 @ 265,582: 13x12
#303 @ 945,184: 18x29
#304 @ 808,418: 15x28
#305 @ 221,762: 13x17
#306 @ 612,684: 21x17
#307 @ 445,758: 28x21
#308 @ 950,273: 15x16
#309 @ 850,303: 12x15
#310 @ 394,285: 16x10
#311 @ 327,5: 22x29
#312 @ 69,435: 24x20
#313 @ 0,532: 14x14
#314 @ 373,950: 13x15
#315 @ 170,89: 21x27
#316 @ 754,36: 15x22
#317 @ 680,266: 29x22
#318 @ 388,450: 29x21
#319 @ 867,471: 25x28
#320 @ 336,278: 27x14
#321 @ 880,816: 14x28
#322 @ 547,278: 24x29
#323 @ 762,824: 6x4
#324 @ 179,492: 13x13
#325 @ 382,289: 17x27
#326 @ 867,461: 17x16
#327 @ 246,495: 10x16
#328 @ 960,200: 12x15
#329 @ 766,19: 23x12
#330 @ 158,119: 10x24
#331 @ 385,919: 11x19
#332 @ 804,637: 27x11
#333 @ 539,841: 19x23
#334 @ 115,963: 26x28
#335 @ 864,465: 22x10
#336 @ 325,679: 23x10
#337 @ 716,414: 11x21
#338 @ 599,636: 13x22
#339 @ 202,816: 23x16
#340 @ 596,652: 24x17
#341 @ 897,253: 18x14
#342 @ 558,192: 11x24
#343 @ 277,839: 20x14
#344 @ 271,671: 17x16
#345 @ 315,407: 19x27
#346 @ 217,934: 11x20
#347 @ 50,336: 27x17
#348 @ 286,823: 23x21
#349 @ 145,351: 24x10
#350 @ 681,802: 11x27
#351 @ 482,240: 24x21
#352 @ 544,629: 17x22
#353 @ 418,511: 15x26
#354 @ 301,251: 14x20
#355 @ 196,969: 27x26
#356 @ 314,687: 16x19
#357 @ 713,10: 25x21
#358 @ 963,626: 20x13
#359 @ 831,771: 24x18
#360 @ 853,546: 14x13
#361 @ 843,804: 23x13
#362 @ 22,941: 22x10
#363 @ 720,967: 18x15
#364 @ 718,956: 27x25
#365 @ 131,975: 25x21
#366 @ 216,668: 16x20
#367 @ 370,902: 21x10
#368 @ 794,694: 27x14
#369 @ 669,220: 27x24
#370 @ 89,659: 23x12
#371 @ 283,257: 11x18
#372 @ 240,306: 19x20
#373 @ 941,160: 29x18
#374 @ 421,709: 18x18
#375 @ 655,603: 20x27
#376 @ 290,879: 17x20
#377 @ 873,598: 10x22
#378 @ 555,653: 28x19
#379 @ 91,666: 20x16
#380 @ 263,488: 26x27
#381 @ 596,330: 22x23
#382 @ 237,773: 27x19
#383 @ 351,76: 14x25
#384 @ 129,221: 25x27
#385 @ 424,820: 11x23
#386 @ 225,952: 12x18
#387 @ 215,869: 20x25
#388 @ 405,644: 19x19
#389 @ 858,19: 17x28
#390 @ 829,252: 22x10
#391 @ 119,167: 27x19
#392 @ 335,196: 27x11
#393 @ 97,677: 14x13
#394 @ 588,931: 27x27
#395 @ 606,293: 20x24
#396 @ 930,964: 20x20
#397 @ 12,273: 24x23
#398 @ 567,107: 15x18
#399 @ 150,354: 24x10
#400 @ 913,732: 25x19
#401 @ 916,960: 29x13
#402 @ 443,924: 28x16
#403 @ 354,158: 11x29
#404 @ 364,471: 26x22
#405 @ 603,132: 14x29
#406 @ 60,548: 13x23
#407 @ 399,453: 16x11
#408 @ 964,728: 11x13
#409 @ 8,1: 23x15
#410 @ 18,491: 23x11
#411 @ 641,948: 11x22
#412 @ 367,359: 18x29
#413 @ 624,694: 18x24
#414 @ 670,939: 20x24
#415 @ 665,500: 20x29
#416 @ 525,881: 23x14
#417 @ 317,737: 16x24
#418 @ 651,151: 17x12
#419 @ 479,84: 14x17
#420 @ 684,820: 12x29
#421 @ 491,618: 20x15
#422 @ 718,880: 11x23
#423 @ 831,404: 15x25
#424 @ 381,950: 12x20
#425 @ 606,634: 10x17
#426 @ 227,786: 18x18
#427 @ 536,180: 25x22
#428 @ 859,177: 20x12
#429 @ 460,534: 20x25
#430 @ 884,940: 22x24
#431 @ 171,836: 22x21
#432 @ 32,355: 11x27
#433 @ 157,828: 15x28
#434 @ 636,468: 16x29
#435 @ 883,511: 16x27
#436 @ 51,331: 15x12
#437 @ 807,501: 18x12
#438 @ 62,180: 13x12
#439 @ 312,528: 19x15
#440 @ 166,511: 13x14
#441 @ 482,611: 12x12
#442 @ 210,579: 11x22
#443 @ 728,625: 14x17
#444 @ 456,717: 13x21
#445 @ 606,273: 12x21
#446 @ 303,466: 22x15
#447 @ 976,355: 19x12
#448 @ 720,771: 11x13
#449 @ 290,274: 12x24
#450 @ 11,807: 12x25
#451 @ 409,660: 15x12
#452 @ 913,523: 26x14
#453 @ 438,897: 10x11
#454 @ 50,270: 17x21
#455 @ 290,423: 15x16
#456 @ 688,235: 10x15
#457 @ 982,343: 16x26
#458 @ 714,779: 27x13
#459 @ 655,667: 13x24
#460 @ 877,221: 10x15
#461 @ 695,674: 17x22
#462 @ 804,159: 15x17
#463 @ 935,682: 28x23
#464 @ 32,190: 25x14
#465 @ 917,691: 24x25
#466 @ 440,369: 25x12
#467 @ 125,193: 23x24
#468 @ 362,638: 24x29
#469 @ 686,89: 28x15
#470 @ 899,495: 23x19
#471 @ 760,679: 29x22
#472 @ 727,206: 7x10
#473 @ 406,446: 21x24
#474 @ 26,333: 17x29
#475 @ 913,952: 20x24
#476 @ 548,628: 16x10
#477 @ 155,872: 24x28
#478 @ 389,904: 22x23
#479 @ 539,210: 16x12
#480 @ 871,680: 13x19
#481 @ 556,595: 13x11
#482 @ 129,531: 19x16
#483 @ 671,637: 25x25
#484 @ 323,698: 21x29
#485 @ 591,617: 15x14
#486 @ 343,252: 20x18
#487 @ 437,206: 15x10
#488 @ 291,408: 23x29
#489 @ 678,92: 17x28
#490 @ 888,233: 10x29
#491 @ 215,831: 14x17
#492 @ 570,752: 24x13
#493 @ 751,331: 18x27
#494 @ 715,956: 16x19
#495 @ 300,679: 17x16
#496 @ 500,392: 20x17
#497 @ 332,704: 24x17
#498 @ 505,499: 27x20
#499 @ 318,473: 13x28
#500 @ 961,528: 14x15
#501 @ 572,190: 20x29
#502 @ 668,762: 12x19
#503 @ 784,38: 27x13
#504 @ 31,253: 29x12
#505 @ 940,849: 26x14
#506 @ 877,88: 17x26
#507 @ 740,714: 20x23
#508 @ 671,373: 21x16
#509 @ 418,713: 23x12
#510 @ 731,649: 24x24
#511 @ 32,279: 29x21
#512 @ 712,907: 27x23
#513 @ 948,516: 19x24
#514 @ 372,177: 13x20
#515 @ 746,936: 11x13
#516 @ 102,828: 4x18
#517 @ 445,18: 19x22
#518 @ 371,84: 18x26
#519 @ 882,80: 21x26
#520 @ 337,906: 17x28
#521 @ 559,749: 11x17
#522 @ 947,303: 24x29
#523 @ 504,945: 17x23
#524 @ 24,801: 15x22
#525 @ 527,810: 15x28
#526 @ 382,305: 12x10
#527 @ 248,568: 15x24
#528 @ 931,735: 10x20
#529 @ 468,773: 10x23
#530 @ 616,255: 19x22
#531 @ 529,873: 19x25
#532 @ 548,799: 15x24
#533 @ 377,165: 28x13
#534 @ 200,638: 21x17
#535 @ 178,758: 16x17
#536 @ 65,940: 22x20
#537 @ 229,679: 24x10
#538 @ 196,906: 7x7
#539 @ 167,518: 15x10
#540 @ 974,455: 26x28
#541 @ 756,49: 17x21
#542 @ 844,632: 21x10
#543 @ 44,532: 11x22
#544 @ 153,612: 19x10
#545 @ 756,34: 17x14
#546 @ 507,233: 11x26
#547 @ 983,759: 12x11
#548 @ 600,41: 25x18
#549 @ 350,403: 17x19
#550 @ 392,624: 26x10
#551 @ 725,862: 28x21
#552 @ 808,315: 11x21
#553 @ 848,771: 29x10
#554 @ 193,954: 26x22
#555 @ 869,909: 14x10
#556 @ 569,677: 26x28
#557 @ 482,11: 24x16
#558 @ 974,474: 23x26
#559 @ 932,830: 16x19
#560 @ 14,262: 16x19
#561 @ 367,902: 28x26
#562 @ 169,485: 16x11
#563 @ 724,637: 25x15
#564 @ 371,609: 26x11
#565 @ 6,829: 17x20
#566 @ 887,827: 22x17
#567 @ 22,31: 19x12
#568 @ 268,702: 23x18
#569 @ 98,232: 14x14
#570 @ 446,700: 10x29
#571 @ 774,780: 12x27
#572 @ 624,168: 20x14
#573 @ 814,297: 23x23
#574 @ 419,526: 25x27
#575 @ 441,885: 13x20
#576 @ 890,698: 25x21
#577 @ 1,900: 21x29
#578 @ 328,917: 13x20
#579 @ 963,189: 26x22
#580 @ 858,87: 16x12
#581 @ 954,816: 19x29
#582 @ 566,129: 23x18
#583 @ 888,811: 19x27
#584 @ 753,313: 29x21
#585 @ 414,71: 29x10
#586 @ 734,423: 23x13
#587 @ 445,315: 23x13
#588 @ 834,295: 23x16
#589 @ 545,172: 13x25
#590 @ 201,280: 22x18
#591 @ 876,825: 24x15
#592 @ 877,665: 12x27
#593 @ 940,800: 19x11
#594 @ 101,144: 27x25
#595 @ 940,459: 19x26
#596 @ 800,588: 23x20
#597 @ 204,886: 10x21
#598 @ 873,891: 15x19
#599 @ 59,329: 25x15
#600 @ 681,847: 22x18
#601 @ 86,624: 11x29
#602 @ 901,600: 23x13
#603 @ 562,257: 25x19
#604 @ 960,818: 10x23
#605 @ 885,298: 29x18
#606 @ 370,149: 27x24
#607 @ 706,395: 16x17
#608 @ 920,22: 27x19
#609 @ 407,612: 20x12
#610 @ 494,596: 23x15
#611 @ 36,597: 17x27
#612 @ 92,233: 23x15
#613 @ 537,457: 13x21
#614 @ 835,125: 29x14
#615 @ 918,724: 20x13
#616 @ 242,925: 18x14
#617 @ 209,859: 17x17
#618 @ 466,140: 17x21
#619 @ 415,777: 21x28
#620 @ 490,7: 13x20
#621 @ 423,913: 26x23
#622 @ 296,599: 10x28
#623 @ 498,577: 26x16
#624 @ 773,659: 13x15
#625 @ 263,847: 13x17
#626 @ 741,375: 28x26
#627 @ 100,808: 4x3
#628 @ 525,308: 18x26
#629 @ 955,940: 15x28
#630 @ 432,367: 22x24
#631 @ 580,693: 6x3
#632 @ 483,628: 10x11
#633 @ 822,479: 25x25
#634 @ 533,561: 12x23
#635 @ 711,270: 13x24
#636 @ 932,951: 23x24
#637 @ 684,683: 17x26
#638 @ 236,537: 19x28
#639 @ 953,217: 21x23
#640 @ 248,155: 14x18
#641 @ 761,627: 20x23
#642 @ 343,864: 13x13
#643 @ 8,538: 20x19
#644 @ 568,547: 17x25
#645 @ 20,945: 18x23
#646 @ 612,256: 25x12
#647 @ 302,964: 6x17
#648 @ 570,901: 11x22
#649 @ 184,429: 25x13
#650 @ 257,224: 25x24
#651 @ 63,448: 29x11
#652 @ 927,499: 11x23
#653 @ 501,228: 11x23
#654 @ 291,606: 20x20
#655 @ 857,26: 16x16
#656 @ 648,779: 13x22
#657 @ 216,304: 10x15
#658 @ 349,856: 18x29
#659 @ 10,939: 21x26
#660 @ 287,894: 18x17
#661 @ 888,680: 13x15
#662 @ 288,358: 19x29
#663 @ 106,203: 22x25
#664 @ 387,268: 25x27
#665 @ 466,122: 20x29
#666 @ 590,650: 25x12
#667 @ 978,488: 22x11
#668 @ 112,861: 19x14
#669 @ 20,885: 22x12
#670 @ 820,99: 13x21
#671 @ 420,898: 23x27
#672 @ 869,605: 29x26
#673 @ 123,471: 25x23
#674 @ 652,564: 17x28
#675 @ 414,883: 23x11
#676 @ 890,529: 22x27
#677 @ 406,372: 25x29
#678 @ 39,180: 27x20
#679 @ 12,928: 16x29
#680 @ 516,301: 10x21
#681 @ 681,314: 25x28
#682 @ 980,764: 18x29
#683 @ 879,571: 16x12
#684 @ 561,511: 22x24
#685 @ 226,257: 16x10
#686 @ 269,580: 11x16
#687 @ 217,473: 20x26
#688 @ 493,587: 21x27
#689 @ 19,767: 27x23
#690 @ 369,802: 14x11
#691 @ 656,976: 25x22
#692 @ 504,592: 11x24
#693 @ 143,677: 11x22
#694 @ 554,971: 12x25
#695 @ 968,698: 28x29
#696 @ 290,838: 23x18
#697 @ 572,419: 28x19
#698 @ 459,554: 13x17
#699 @ 393,375: 29x14
#700 @ 646,968: 12x22
#701 @ 917,18: 25x24
#702 @ 534,921: 20x23
#703 @ 217,679: 18x19
#704 @ 476,792: 22x28
#705 @ 844,833: 7x13
#706 @ 215,583: 18x23
#707 @ 688,18: 8x14
#708 @ 974,916: 25x18
#709 @ 214,842: 12x18
#710 @ 254,316: 24x22
#711 @ 831,722: 8x15
#712 @ 217,256: 23x20
#713 @ 956,281: 12x16
#714 @ 923,797: 16x11
#715 @ 788,40: 11x18
#716 @ 422,193: 22x17
#717 @ 475,84: 17x18
#718 @ 869,61: 24x29
#719 @ 266,189: 12x21
#720 @ 514,472: 18x10
#721 @ 344,314: 13x12
#722 @ 43,679: 26x28
#723 @ 943,845: 26x12
#724 @ 287,235: 28x27
#725 @ 503,615: 24x24
#726 @ 436,37: 10x18
#727 @ 312,576: 23x10
#728 @ 934,178: 21x29
#729 @ 925,693: 16x12
#730 @ 272,722: 19x18
#731 @ 66,539: 12x14
#732 @ 117,429: 14x23
#733 @ 213,557: 23x17
#734 @ 293,70: 18x28
#735 @ 804,578: 19x10
#736 @ 683,694: 28x24
#737 @ 14,280: 18x6
#738 @ 134,197: 22x12
#739 @ 928,398: 12x12
#740 @ 407,48: 14x29
#741 @ 440,702: 14x16
#742 @ 173,504: 20x24
#743 @ 572,559: 29x20
#744 @ 421,890: 23x28
#745 @ 605,628: 21x26
#746 @ 497,940: 18x19
#747 @ 61,99: 24x20
#748 @ 50,212: 11x28
#749 @ 314,185: 28x15
#750 @ 190,897: 22x25
#751 @ 97,75: 16x29
#752 @ 287,369: 15x11
#753 @ 435,218: 11x25
#754 @ 403,720: 22x15
#755 @ 353,696: 19x17
#756 @ 323,2: 25x20
#757 @ 744,581: 19x26
#758 @ 294,962: 26x22
#759 @ 567,7: 13x27
#760 @ 974,116: 21x13
#761 @ 781,767: 22x27
#762 @ 790,657: 24x21
#763 @ 860,622: 11x15
#764 @ 547,163: 24x26
#765 @ 794,156: 12x20
#766 @ 691,836: 13x16
#767 @ 576,118: 27x26
#768 @ 841,132: 29x11
#769 @ 210,582: 24x24
#770 @ 377,703: 20x25
#771 @ 844,558: 15x19
#772 @ 860,636: 18x23
#773 @ 246,788: 23x28
#774 @ 894,567: 15x17
#775 @ 284,892: 26x15
#776 @ 931,479: 12x26
#777 @ 116,684: 26x13
#778 @ 345,855: 21x10
#779 @ 725,204: 13x16
#780 @ 781,257: 23x19
#781 @ 677,959: 28x14
#782 @ 535,813: 17x19
#783 @ 538,806: 12x19
#784 @ 184,501: 22x17
#785 @ 596,661: 12x15
#786 @ 3,784: 16x21
#787 @ 556,880: 16x23
#788 @ 626,896: 17x11
#789 @ 944,823: 16x13
#790 @ 13,357: 20x15
#791 @ 363,73: 18x22
#792 @ 896,304: 28x26
#793 @ 455,519: 16x14
#794 @ 2,957: 14x26
#795 @ 148,552: 28x15
#796 @ 880,397: 13x17
#797 @ 759,676: 11x26
#798 @ 957,733: 5x5
#799 @ 450,892: 26x12
#800 @ 877,203: 23x22
#801 @ 500,533: 17x23
#802 @ 533,474: 21x24
#803 @ 169,797: 17x26
#804 @ 283,367: 25x27
#805 @ 797,325: 25x17
#806 @ 114,214: 22x19
#807 @ 462,317: 15x11
#808 @ 416,530: 28x16
#809 @ 562,167: 17x21
#810 @ 472,73: 27x14
#811 @ 397,669: 29x19
#812 @ 267,690: 16x18
#813 @ 412,567: 21x18
#814 @ 43,458: 11x16
#815 @ 350,236: 28x24
#816 @ 746,35: 17x27
#817 @ 665,176: 7x5
#818 @ 482,3: 10x15
#819 @ 877,908: 15x18
#820 @ 537,210: 27x12
#821 @ 41,795: 29x20
#822 @ 560,174: 10x10
#823 @ 267,380: 15x10
#824 @ 852,584: 25x22
#825 @ 955,937: 17x21
#826 @ 212,232: 10x21
#827 @ 396,498: 27x10
#828 @ 176,285: 25x29
#829 @ 96,460: 28x11
#830 @ 132,56: 23x29
#831 @ 457,85: 22x14
#832 @ 832,949: 22x14
#833 @ 745,615: 14x10
#834 @ 295,879: 11x16
#835 @ 357,451: 21x18
#836 @ 74,944: 13x26
#837 @ 943,124: 24x16
#838 @ 202,641: 19x26
#839 @ 877,276: 22x19
#840 @ 14,546: 13x21
#841 @ 925,699: 29x16
#842 @ 55,205: 28x18
#843 @ 45,526: 14x19
#844 @ 270,692: 22x15
#845 @ 375,916: 12x18
#846 @ 463,311: 12x20
#847 @ 754,348: 15x12
#848 @ 348,433: 14x27
#849 @ 69,335: 29x22
#850 @ 205,611: 23x12
#851 @ 333,514: 17x27
#852 @ 557,905: 25x24
#853 @ 824,785: 10x17
#854 @ 983,494: 13x16
#855 @ 391,926: 12x24
#856 @ 369,366: 12x7
#857 @ 370,456: 19x12
#858 @ 106,729: 11x13
#859 @ 126,420: 12x18
#860 @ 968,504: 23x18
#861 @ 887,140: 20x26
#862 @ 780,696: 14x28
#863 @ 405,753: 22x20
#864 @ 965,899: 17x21
#865 @ 855,56: 12x25
#866 @ 225,149: 23x28
#867 @ 834,829: 10x25
#868 @ 205,133: 23x10
#869 @ 219,125: 27x15
#870 @ 267,819: 28x28
#871 @ 583,172: 15x28
#872 @ 320,52: 20x28
#873 @ 380,675: 25x29
#874 @ 440,199: 10x28
#875 @ 553,927: 29x12
#876 @ 124,458: 10x17
#877 @ 326,7: 25x29
#878 @ 933,165: 14x28
#879 @ 440,707: 24x21
#880 @ 870,803: 22x17
#881 @ 134,899: 10x15
#882 @ 378,951: 13x18
#883 @ 908,745: 14x13
#884 @ 144,202: 26x11
#885 @ 685,363: 10x21
#886 @ 327,159: 3x10
#887 @ 215,569: 18x17
#888 @ 872,308: 13x14
#889 @ 55,894: 18x27
#890 @ 697,899: 21x29
#891 @ 447,954: 20x25
#892 @ 76,330: 28x13
#893 @ 817,378: 12x25
#894 @ 696,235: 21x20
#895 @ 121,460: 10x29
#896 @ 307,76: 19x23
#897 @ 99,346: 14x11
#898 @ 534,170: 16x28
#899 @ 180,474: 11x27
#900 @ 315,159: 25x21
#901 @ 975,107: 14x21
#902 @ 116,277: 27x17
#903 @ 959,516: 20x20
#904 @ 495,749: 17x16
#905 @ 334,230: 10x26
#906 @ 742,822: 21x18
#907 @ 138,886: 11x22
#908 @ 30,442: 24x19
#909 @ 922,571: 17x17
#910 @ 276,572: 19x21
#911 @ 878,408: 18x14
#912 @ 665,726: 11x17
#913 @ 73,260: 20x13
#914 @ 956,897: 15x15
#915 @ 891,321: 28x23
#916 @ 185,266: 29x24
#917 @ 648,160: 14x19
#918 @ 670,760: 14x14
#919 @ 9,659: 16x22
#920 @ 145,680: 5x9
#921 @ 527,439: 26x22
#922 @ 599,592: 26x29
#923 @ 208,204: 22x19
#924 @ 588,42: 15x20
#925 @ 904,500: 28x21
#926 @ 792,116: 29x27
#927 @ 7,656: 29x11
#928 @ 704,920: 12x29
#929 @ 122,528: 19x15
#930 @ 92,637: 23x15
#931 @ 867,756: 22x28
#932 @ 190,489: 11x22
#933 @ 207,604: 14x18
#934 @ 712,273: 29x17
#935 @ 961,18: 21x29
#936 @ 447,318: 14x23
#937 @ 519,912: 18x19
#938 @ 515,589: 29x22
#939 @ 648,818: 21x22
#940 @ 368,415: 26x24
#941 @ 16,345: 14x13
#942 @ 634,708: 13x10
#943 @ 843,667: 26x23
#944 @ 373,459: 16x19
#945 @ 899,873: 22x22
#946 @ 256,480: 10x19
#947 @ 505,236: 19x10
#948 @ 571,530: 22x28
#949 @ 333,771: 15x28
#950 @ 230,923: 17x13
#951 @ 786,566: 28x29
#952 @ 541,274: 14x11
#953 @ 889,85: 27x22
#954 @ 603,445: 26x27
#955 @ 888,458: 28x14
#956 @ 165,123: 14x16
#957 @ 721,81: 22x23
#958 @ 621,470: 19x20
#959 @ 290,391: 17x28
#960 @ 363,617: 22x17
#961 @ 527,198: 17x22
#962 @ 945,851: 17x11
#963 @ 549,864: 28x28
#964 @ 833,863: 19x20
#965 @ 960,603: 18x26
#966 @ 506,131: 5x21
#967 @ 592,630: 14x15
#968 @ 72,429: 13x24
#969 @ 553,153: 16x25
#970 @ 776,601: 29x21
#971 @ 904,460: 7x7
#972 @ 423,498: 29x27
#973 @ 12,953: 12x13
#974 @ 198,664: 21x24
#975 @ 765,636: 21x19
#976 @ 787,299: 29x29
#977 @ 966,495: 10x27
#978 @ 314,546: 28x26
#979 @ 810,316: 15x20
#980 @ 725,778: 24x13
#981 @ 829,414: 15x10
#982 @ 739,928: 12x14
#983 @ 656,98: 28x27
#984 @ 146,74: 3x6
#985 @ 642,791: 20x11
#986 @ 887,281: 26x23
#987 @ 511,373: 18x26
#988 @ 13,538: 19x15
#989 @ 845,249: 29x12
#990 @ 205,466: 11x28
#991 @ 12,494: 19x19
#992 @ 508,936: 3x5
#993 @ 543,268: 20x18
#994 @ 955,29: 29x10
#995 @ 925,780: 10x12
#996 @ 412,168: 23x26
#997 @ 719,957: 14x27
#998 @ 809,833: 18x27
#999 @ 800,404: 18x29
#1000 @ 225,935: 14x17
#1001 @ 638,566: 11x12
#1002 @ 140,72: 29x12
#1003 @ 217,755: 17x16
#1004 @ 508,608: 18x12
#1005 @ 546,720: 15x25
#1006 @ 502,380: 29x19
#1007 @ 429,524: 27x19
#1008 @ 334,787: 15x18
#1009 @ 217,949: 14x26
#1010 @ 288,523: 26x22
#1011 @ 534,936: 24x22
#1012 @ 314,404: 13x15
#1013 @ 50,228: 21x25
#1014 @ 584,124: 15x28
#1015 @ 882,110: 17x25
#1016 @ 208,955: 12x25
#1017 @ 30,347: 27x25
#1018 @ 371,898: 21x14
#1019 @ 756,388: 20x28
#1020 @ 184,889: 27x16
#1021 @ 964,461: 17x13
#1022 @ 389,764: 21x29
#1023 @ 712,706: 15x22
#1024 @ 420,191: 11x20
#1025 @ 711,650: 11x29
#1026 @ 361,847: 21x16
#1027 @ 722,418: 24x20
#1028 @ 598,690: 25x28
#1029 @ 753,978: 18x17
#1030 @ 251,676: 18x14
#1031 @ 191,405: 24x13
#1032 @ 830,870: 24x10
#1033 @ 373,801: 21x17
#1034 @ 956,593: 14x23
#1035 @ 380,949: 29x17
#1036 @ 703,765: 19x29
#1037 @ 82,672: 10x11
#1038 @ 17,228: 20x17
#1039 @ 531,343: 25x23
#1040 @ 197,282: 13x15
#1041 @ 169,580: 27x14
#1042 @ 340,156: 20x18
#1043 @ 328,820: 14x12
#1044 @ 187,565: 29x19
#1045 @ 872,178: 13x22
#1046 @ 810,502: 29x14
#1047 @ 543,519: 22x25
#1048 @ 460,726: 19x24
#1049 @ 191,904: 16x14
#1050 @ 190,198: 23x22
#1051 @ 666,197: 13x22
#1052 @ 356,789: 14x22
#1053 @ 639,181: 17x14
#1054 @ 596,643: 27x11
#1055 @ 961,317: 10x18
#1056 @ 433,768: 17x20
#1057 @ 52,795: 28x10
#1058 @ 352,801: 12x17
#1059 @ 669,738: 20x16
#1060 @ 101,863: 22x15
#1061 @ 803,141: 17x23
#1062 @ 198,472: 22x16
#1063 @ 642,518: 24x15
#1064 @ 440,273: 27x19
#1065 @ 588,927: 16x24
#1066 @ 303,563: 27x22
#1067 @ 689,721: 28x16
#1068 @ 836,874: 19x15
#1069 @ 752,809: 21x28
#1070 @ 790,242: 22x26
#1071 @ 435,204: 11x29
#1072 @ 608,291: 25x12
#1073 @ 176,419: 18x28
#1074 @ 598,372: 12x26
#1075 @ 890,293: 19x14
#1076 @ 569,33: 20x25
#1077 @ 127,803: 29x17
#1078 @ 552,169: 24x14
#1079 @ 983,484: 15x27
#1080 @ 772,662: 12x28
#1081 @ 678,178: 19x23
#1082 @ 277,899: 29x21
#1083 @ 588,229: 12x29
#1084 @ 844,229: 25x25
#1085 @ 688,913: 22x26
#1086 @ 470,882: 22x21
#1087 @ 813,678: 10x29
#1088 @ 427,181: 23x19
#1089 @ 8,941: 26x19
#1090 @ 946,802: 16x10
#1091 @ 646,610: 17x14
#1092 @ 701,281: 26x10
#1093 @ 240,217: 22x18
#1094 @ 120,214: 29x18
#1095 @ 854,794: 18x19
#1096 @ 179,767: 13x11
#1097 @ 250,383: 23x29
#1098 @ 519,277: 13x10
#1099 @ 395,618: 11x10
#1100 @ 886,893: 17x23
#1101 @ 429,436: 19x17
#1102 @ 200,938: 29x10
#1103 @ 124,794: 24x14
#1104 @ 874,265: 10x15
#1105 @ 483,784: 20x29
#1106 @ 489,933: 13x28
#1107 @ 222,932: 23x27
#1108 @ 714,633: 21x29
#1109 @ 761,322: 15x20
#1110 @ 83,347: 24x12
#1111 @ 523,889: 23x28
#1112 @ 101,672: 16x23
#1113 @ 936,704: 16x27
#1114 @ 861,236: 17x25
#1115 @ 951,125: 24x26
#1116 @ 688,681: 15x11
#1117 @ 391,758: 27x23
#1118 @ 808,778: 9x5
#1119 @ 831,238: 10x25
#1120 @ 204,474: 9x10
#1121 @ 625,813: 16x15
#1122 @ 45,886: 17x23
#1123 @ 561,938: 18x13
#1124 @ 350,880: 27x14
#1125 @ 628,401: 18x22
#1126 @ 488,807: 27x28
#1127 @ 848,947: 14x11
#1128 @ 863,76: 15x28
#1129 @ 174,893: 27x29
#1130 @ 894,483: 22x29
#1131 @ 680,78: 22x27
#1132 @ 748,604: 21x11
#1133 @ 855,759: 14x13
#1134 @ 953,117: 12x27
#1135 @ 930,402: 3x4
#1136 @ 663,174: 12x10
#1137 @ 396,869: 18x16
#1138 @ 451,559: 12x13
#1139 @ 709,79: 16x11
#1140 @ 804,970: 10x25
#1141 @ 339,287: 27x13
#1142 @ 181,961: 25x13
#1143 @ 553,208: 11x26
#1144 @ 192,417: 10x28
#1145 @ 77,92: 19x27
#1146 @ 796,121: 22x24
#1147 @ 194,616: 11x14
#1148 @ 595,147: 15x29
#1149 @ 84,437: 26x28
#1150 @ 338,87: 16x29
#1151 @ 806,774: 14x13
#1152 @ 841,880: 15x16
#1153 @ 650,491: 15x29
#1154 @ 501,498: 22x20
#1155 @ 611,632: 15x11
#1156 @ 753,732: 28x26
#1157 @ 199,966: 23x14
#1158 @ 873,812: 14x3
#1159 @ 25,12: 16x15
#1160 @ 96,800: 16x22
#1161 @ 354,716: 12x18
#1162 @ 612,404: 25x13
#1163 @ 193,897: 12x11
#1164 @ 284,376: 16x19
#1165 @ 203,636: 16x25
#1166 @ 797,583: 28x22
#1167 @ 558,259: 29x23
#1168 @ 391,930: 17x11
#1169 @ 120,459: 18x18
#1170 @ 708,270: 23x14
#1171 @ 474,974: 29x20
#1172 @ 872,333: 24x15
#1173 @ 67,183: 16x19
#1174 @ 915,799: 23x14
#1175 @ 662,437: 17x15
#1176 @ 925,831: 20x22
#1177 @ 977,500: 20x11
#1178 @ 475,766: 25x21
#1179 @ 281,677: 17x28
#1180 @ 425,562: 17x29
#1181 @ 542,568: 10x22
#1182 @ 702,684: 28x11
#1183 @ 157,221: 25x29
#1184 @ 490,606: 28x18
#1185 @ 654,432: 17x21
#1186 @ 523,271: 23x26
#1187 @ 15,937: 28x13
#1188 @ 379,196: 18x21
#1189 @ 337,730: 26x11
#1190 @ 840,256: 16x13
#1191 @ 651,955: 13x13
#1192 @ 174,225: 10x16
#1193 @ 188,212: 27x20
#1194 @ 553,184: 11x10
#1195 @ 504,129: 10x28
#1196 @ 344,568: 10x10
#1197 @ 951,788: 23x22
#1198 @ 212,552: 28x28
#1199 @ 775,577: 26x22
#1200 @ 957,757: 15x29
#1201 @ 56,956: 15x10
#1202 @ 833,931: 16x19
#1203 @ 880,447: 14x23
#1204 @ 430,840: 23x25
#1205 @ 673,641: 14x28
#1206 @ 242,187: 28x18
#1207 @ 757,7: 20x28
#1208 @ 149,450: 12x27
#1209 @ 37,248: 23x20
#1210 @ 335,712: 21x23
#1211 @ 839,767: 27x24
#1212 @ 721,605: 27x15
#1213 @ 611,334: 11x26
#1214 @ 515,933: 25x13
#1215 @ 210,772: 29x10
#1216 @ 492,789: 16x16
#1217 @ 188,82: 24x15
#1218 @ 877,304: 26x14
#1219 @ 829,713: 15x29
#1220 @ 172,510: 23x28
#1221 @ 842,828: 15x23
#1222 @ 88,161: 24x13
#1223 @ 463,290: 13x22
#1224 @ 682,230: 22x12
#1225 @ 713,911: 29x25
#1226 @ 317,157: 26x16
#1227 @ 894,150: 16x28
#1228 @ 906,551: 14x23
#1229 @ 131,562: 23x28
#1230 @ 127,33: 22x23
#1231 @ 134,50: 14x24
#1232 @ 591,409: 12x20
#1233 @ 218,554: 18x26";
    }

    public class Day_4
    {
        public class GuardLog
        {
            public string GuardId;
            public LogType Type;
            public DateTime LogTime;
            public int SleepMinute;
            public int AwakeMinute;
        }

        public enum LogType {
            BeginShift = 0,
            Sleep= 1,
            Awake= 2,
            Unknown= 3
        }

        private static string guardId;
        public static GuardLog parseGuardLog(string logLine)
        {
            var logData = logLine.Substring(18).Trim();
            var tokens = logData.Split(new[] { " " }, StringSplitOptions.None);
            if (tokens[0].Equals("Guard"))
            {
                guardId = tokens[1];
                return null;
            }

            var guardLog = new GuardLog();
            guardLog.LogTime = DateTime.Parse(logLine.Substring(1, 16));
            guardLog.GuardId = guardId;
            guardLog.SleepMinute = guardLog.LogTime.Minute;
            if (tokens[0].Equals("falls"))
            {
                guardLog.Type = LogType.Sleep;
                return guardLog;
            }
            else if (tokens[0].Equals("wakes"))
            {
                guardLog.Type = LogType.Awake;
                return guardLog;
            }
            else
            {
                guardId = tokens[1];
            }
            return null;
        }

        public static string Pad(string letter, int count)
        {
            var r = "";
            for (int idx = 0; idx < count; idx++)
                r += letter;
            return r;
        }

        public static void First()
        {
            var logLines = guardLog
                    .Split(new[] { "\r\n" }, StringSplitOptions.None)
                    .OrderBy( s => s.Substring(0,18));

            var logEntries= logLines.Select(parseGuardLog).Where(le => le != null);
            Console.WriteLine($"{logEntries.Count()} entries read");
            // group by guard
            var guardLogs = logEntries.GroupBy(gl => gl.GuardId);
            var maxMinutePerGuard = new List<Tuple<string, int>>();
            var sleepMinutes = new List<Tuple<string, string>>(); // GuardId, sleepPattern
            foreach (var guardLog in guardLogs)
            {
                Console.WriteLine($"{guardLog.First().GuardId} has {guardLog.Count()} entries");
                var totMinutes = 0;
                foreach (var guardLogDay in guardLog.GroupBy(gl => gl.LogTime.Date))
                {
                    var logEntires = guardLogDay.ToArray();
                    // calculate sleep array;
                    var sleepPattern = "";
                    var lastMinute = 0;
                    var state = LogType.Awake;
                    foreach (var logEntry in logEntires)
                    {
                        var minutes = logEntry.SleepMinute - lastMinute;
                        sleepPattern += Pad(state == LogType.Awake ? "." : "#", minutes);
                        lastMinute = logEntry.SleepMinute;
                        state = logEntry.Type;
                    }
                    sleepPattern += Pad(state == LogType.Awake ? "." : "#", 60 - sleepPattern.Length);
                    var dayMinutes = sleepPattern.AsEnumerable().Where(c => c == '#').Count();
                    sleepMinutes.Add(new Tuple<string, string>(guardLog.First().GuardId, sleepPattern));
                    // get max sleep minutes per guard;
                    totMinutes += dayMinutes;
                }
                maxMinutePerGuard.Add(new Tuple<string, int>(guardLog.First().GuardId, totMinutes));
                Console.WriteLine($"{guardLog.First().GuardId} sleeps {totMinutes} in total");
            }

            var maxGuard = maxMinutePerGuard.OrderByDescending(mpg => mpg.Item2).First();
            Console.WriteLine($"Entries from {maxMinutePerGuard.Count} Guards logged, {maxGuard.Item1} slept longest ({maxGuard.Item2} minutes)");

            var maxGuardPatterns = sleepMinutes.Where(sm => sm.Item1 == maxGuard.Item1).Select(sm => sm.Item2);
            var sleepsAtMinute = new int[60];
            for(var m = 0; m < 60; m++)
            {
                foreach (var logEntry in maxGuardPatterns)
                    if (logEntry[m] == '#') sleepsAtMinute[m]++;
            }
            var maxIdx = -1;
            var maxMinute = -1;
            for (var m = 0; m < 60; m++)
            {
                if (maxMinute < sleepsAtMinute[m])
                {
                    maxMinute = sleepsAtMinute[m];
                    maxIdx = m;
                }
            }
            Console.WriteLine($"Guard {maxGuard.Item1} slept most often at {maxIdx} minutes past midnight. => {int.Parse(maxGuard.Item1.Substring(1)) * maxIdx}");
        }

        public static void Second()
        {
            var logLines = guardLog
                    .Split(new[] { "\r\n" }, StringSplitOptions.None)
                    .OrderBy(s => s.Substring(0, 18));

            var logEntries = logLines.Select(parseGuardLog).Where(le => le != null);
            Console.WriteLine($"{logEntries.Count()} entries read");

            var sleepMinuteGuards = new List<Tuple<string, int[]>>();
            // group by guard
            var guardLogs = logEntries.GroupBy(gl => gl.GuardId);
            foreach (var guardLog in guardLogs)
            {
                Console.WriteLine($"{guardLog.First().GuardId} has {guardLog.Count()} entries");

                var sleepPatterns = new List<string>();
                foreach (var guardLogDay in guardLog.GroupBy(gl => gl.LogTime.Date))
                {
                    var logEntires = guardLogDay.ToArray();
                    // calculate sleep array;
                    var sleepPattern = "";
                    var lastMinute = 0;
                    var state = LogType.Awake;
                    foreach (var logEntry in logEntires)
                    {
                        var minutes = logEntry.SleepMinute - lastMinute;
                        sleepPattern += Pad(state == LogType.Awake ? "." : "#", minutes);
                        lastMinute = logEntry.SleepMinute;
                        state = logEntry.Type;
                    }
                    sleepPattern += Pad(state == LogType.Awake ? "." : "#", 60 - sleepPattern.Length);
                    sleepPatterns.Add(sleepPattern);
                }

                var sleepsAtMinute = new int[60];
                for (var m = 0; m < 60; m++)
                {
                    foreach(var pattern in sleepPatterns)
                    if (pattern[m] == '#') sleepsAtMinute[m]++;
                }

                sleepMinuteGuards.Add(new Tuple<string, int[]>(guardLog.First().GuardId, sleepsAtMinute));
            }

            var maxGuard = -1;
            var maxGuardIdx = -1;
            var maxGuardMinute = -1;
            foreach(var sleepGuard in sleepMinuteGuards)
            {
                var maxIdx = -1;
                var maxMinute = -1;

                for (var m = 0; m < 60; m++)
                {
                    var min = sleepGuard.Item2[m];
                    if (maxMinute < min)
                    {
                        maxMinute = min;
                        maxIdx = m;
                    }
                }
                if (maxGuardMinute < maxMinute)
                {
                    maxGuard = int.Parse(sleepGuard.Item1.Substring(1));
                    maxGuardIdx = maxIdx;
                    maxGuardMinute = maxMinute;
                }
                Console.WriteLine($"Guard {sleepGuard.Item1} slept most often at {maxIdx} minutes past midnight, {maxMinute} times.");
            }
            Console.WriteLine($"Guard {maxGuard} slept most often at {maxGuardIdx} minutes past midnight, {maxGuardMinute} times. => {maxGuard * maxGuardIdx}");
        }

        static string guardLog =
@"[1518-04-21 00:57] wakes up
[1518-09-03 00:12] falls asleep
[1518-04-21 00:04] Guard #3331 begins shift
[1518-10-29 00:51] falls asleep
[1518-06-12 00:02] Guard #3109 begins shift
[1518-06-01 00:46] wakes up
[1518-03-07 00:02] Guard #653 begins shift
[1518-10-06 00:00] Guard #2339 begins shift
[1518-05-20 00:47] wakes up
[1518-10-08 00:58] wakes up
[1518-04-19 00:57] wakes up
[1518-04-16 00:28] falls asleep
[1518-04-12 00:33] wakes up
[1518-04-21 00:19] falls asleep
[1518-08-04 00:52] wakes up
[1518-07-09 00:02] falls asleep
[1518-03-24 00:22] wakes up
[1518-11-19 00:28] falls asleep
[1518-09-18 00:38] falls asleep
[1518-07-28 00:00] Guard #3331 begins shift
[1518-09-18 00:39] wakes up
[1518-07-13 23:59] Guard #653 begins shift
[1518-05-15 00:16] wakes up
[1518-03-31 00:53] wakes up
[1518-05-06 23:46] Guard #2543 begins shift
[1518-04-09 00:28] falls asleep
[1518-04-12 00:23] falls asleep
[1518-05-18 00:50] wakes up
[1518-03-16 00:01] Guard #1117 begins shift
[1518-06-13 00:19] falls asleep
[1518-09-15 00:45] wakes up
[1518-03-23 00:58] wakes up
[1518-08-25 00:18] falls asleep
[1518-03-16 00:23] falls asleep
[1518-10-16 00:41] wakes up
[1518-11-09 00:37] wakes up
[1518-07-05 00:03] falls asleep
[1518-09-24 00:16] falls asleep
[1518-05-18 23:49] Guard #3079 begins shift
[1518-09-03 00:28] wakes up
[1518-03-12 00:47] falls asleep
[1518-09-01 00:47] wakes up
[1518-06-23 23:48] Guard #971 begins shift
[1518-03-27 00:34] wakes up
[1518-06-18 00:40] falls asleep
[1518-03-02 00:48] wakes up
[1518-04-11 00:48] wakes up
[1518-03-31 00:46] wakes up
[1518-08-07 00:57] wakes up
[1518-03-04 00:22] falls asleep
[1518-04-10 00:57] wakes up
[1518-05-16 00:00] Guard #2179 begins shift
[1518-06-06 00:14] wakes up
[1518-03-20 00:54] wakes up
[1518-08-01 00:55] wakes up
[1518-07-03 00:00] Guard #1069 begins shift
[1518-10-14 00:47] falls asleep
[1518-06-01 00:03] falls asleep
[1518-07-10 00:35] falls asleep
[1518-11-12 23:56] Guard #3461 begins shift
[1518-09-04 00:39] falls asleep
[1518-03-15 00:47] wakes up
[1518-04-10 00:30] wakes up
[1518-03-21 00:52] wakes up
[1518-05-09 00:03] Guard #1877 begins shift
[1518-09-29 00:45] wakes up
[1518-03-25 00:37] wakes up
[1518-10-11 00:57] wakes up
[1518-11-09 00:16] wakes up
[1518-08-10 00:18] falls asleep
[1518-06-24 00:30] falls asleep
[1518-08-01 00:54] falls asleep
[1518-08-14 00:12] falls asleep
[1518-10-21 00:46] wakes up
[1518-03-18 00:48] falls asleep
[1518-03-25 23:59] Guard #3331 begins shift
[1518-06-05 23:47] Guard #1117 begins shift
[1518-07-18 00:04] falls asleep
[1518-11-05 00:48] falls asleep
[1518-11-19 00:43] wakes up
[1518-04-16 00:39] wakes up
[1518-09-30 00:46] wakes up
[1518-10-31 00:01] Guard #3079 begins shift
[1518-07-13 00:11] falls asleep
[1518-07-05 00:47] wakes up
[1518-03-22 23:59] Guard #1877 begins shift
[1518-04-18 00:45] wakes up
[1518-08-15 00:49] falls asleep
[1518-04-03 23:57] Guard #2543 begins shift
[1518-07-08 00:29] falls asleep
[1518-06-21 00:41] wakes up
[1518-07-18 00:38] wakes up
[1518-04-29 00:20] wakes up
[1518-10-31 00:56] wakes up
[1518-08-05 00:26] wakes up
[1518-10-03 00:15] falls asleep
[1518-10-05 00:51] wakes up
[1518-04-19 00:43] falls asleep
[1518-10-18 00:30] falls asleep
[1518-10-03 00:04] Guard #2543 begins shift
[1518-03-15 00:40] falls asleep
[1518-06-15 00:16] falls asleep
[1518-06-11 00:00] Guard #1093 begins shift
[1518-05-13 00:00] Guard #919 begins shift
[1518-07-25 00:05] falls asleep
[1518-03-05 00:03] Guard #3079 begins shift
[1518-04-05 00:53] wakes up
[1518-06-16 23:56] Guard #727 begins shift
[1518-07-25 23:50] Guard #2339 begins shift
[1518-04-11 00:09] wakes up
[1518-11-14 00:27] falls asleep
[1518-10-28 00:57] wakes up
[1518-07-11 00:53] falls asleep
[1518-06-27 00:35] wakes up
[1518-10-23 23:47] Guard #3331 begins shift
[1518-11-10 00:36] falls asleep
[1518-08-13 00:46] wakes up
[1518-03-02 00:02] Guard #3079 begins shift
[1518-04-05 00:00] Guard #683 begins shift
[1518-10-17 00:28] wakes up
[1518-10-17 00:48] wakes up
[1518-06-25 00:18] wakes up
[1518-06-21 00:11] falls asleep
[1518-07-09 00:51] wakes up
[1518-03-28 00:45] wakes up
[1518-09-21 23:46] Guard #3079 begins shift
[1518-07-18 23:57] Guard #971 begins shift
[1518-03-22 00:29] falls asleep
[1518-06-24 00:49] wakes up
[1518-09-30 23:50] Guard #2179 begins shift
[1518-06-13 00:07] falls asleep
[1518-07-16 00:04] Guard #2179 begins shift
[1518-11-17 00:51] wakes up
[1518-04-28 00:29] falls asleep
[1518-11-11 00:54] wakes up
[1518-10-07 00:46] falls asleep
[1518-11-18 00:15] falls asleep
[1518-05-22 00:51] wakes up
[1518-03-22 00:54] falls asleep
[1518-10-29 00:04] Guard #1931 begins shift
[1518-10-22 00:21] falls asleep
[1518-07-26 00:02] falls asleep
[1518-03-27 00:54] wakes up
[1518-09-04 00:00] Guard #653 begins shift
[1518-06-24 00:05] falls asleep
[1518-10-15 00:53] wakes up
[1518-05-07 00:54] wakes up
[1518-07-30 23:59] Guard #2179 begins shift
[1518-05-07 00:37] falls asleep
[1518-05-09 00:07] falls asleep
[1518-07-03 00:47] wakes up
[1518-03-28 00:02] Guard #653 begins shift
[1518-08-11 00:19] falls asleep
[1518-05-19 23:59] Guard #2339 begins shift
[1518-10-21 00:56] wakes up
[1518-05-26 23:56] Guard #1117 begins shift
[1518-11-18 00:16] wakes up
[1518-10-11 00:24] wakes up
[1518-08-11 00:11] falls asleep
[1518-03-20 00:18] falls asleep
[1518-09-29 00:34] falls asleep
[1518-04-11 23:59] Guard #1069 begins shift
[1518-05-24 00:35] falls asleep
[1518-11-15 00:36] falls asleep
[1518-05-15 00:51] falls asleep
[1518-09-20 00:13] falls asleep
[1518-08-01 00:20] falls asleep
[1518-09-01 00:01] Guard #1877 begins shift
[1518-06-15 00:00] Guard #919 begins shift
[1518-08-09 00:00] Guard #2179 begins shift
[1518-03-12 00:11] falls asleep
[1518-04-23 00:01] Guard #3331 begins shift
[1518-03-23 00:43] falls asleep
[1518-03-14 00:00] falls asleep
[1518-10-29 00:52] wakes up
[1518-05-08 00:18] falls asleep
[1518-10-20 00:34] falls asleep
[1518-05-05 23:47] Guard #1093 begins shift
[1518-11-01 23:58] Guard #1409 begins shift
[1518-07-05 23:56] Guard #3319 begins shift
[1518-11-03 00:49] wakes up
[1518-09-12 00:59] wakes up
[1518-07-16 00:17] falls asleep
[1518-08-02 00:05] falls asleep
[1518-03-02 00:52] wakes up
[1518-03-04 00:46] wakes up
[1518-09-16 00:40] falls asleep
[1518-05-15 00:15] falls asleep
[1518-07-22 00:46] wakes up
[1518-05-05 00:16] falls asleep
[1518-03-10 23:53] Guard #3079 begins shift
[1518-03-14 00:42] wakes up
[1518-10-26 00:06] falls asleep
[1518-04-11 00:07] falls asleep
[1518-08-23 00:48] wakes up
[1518-05-06 00:49] wakes up
[1518-05-14 00:40] wakes up
[1518-06-02 23:51] Guard #1117 begins shift
[1518-03-09 00:53] wakes up
[1518-05-02 00:43] wakes up
[1518-08-06 00:01] Guard #2953 begins shift
[1518-03-01 00:54] wakes up
[1518-04-16 00:57] wakes up
[1518-09-08 00:02] Guard #727 begins shift
[1518-03-11 00:54] wakes up
[1518-03-30 00:17] falls asleep
[1518-11-22 00:53] falls asleep
[1518-11-07 00:41] wakes up
[1518-03-24 00:41] wakes up
[1518-03-10 00:47] wakes up
[1518-04-18 23:58] Guard #919 begins shift
[1518-08-01 00:51] wakes up
[1518-10-09 00:28] falls asleep
[1518-06-17 00:20] falls asleep
[1518-10-23 00:49] wakes up
[1518-07-14 00:18] falls asleep
[1518-08-31 00:20] falls asleep
[1518-06-11 00:56] falls asleep
[1518-10-22 00:00] Guard #3079 begins shift
[1518-06-08 00:24] wakes up
[1518-09-30 00:51] falls asleep
[1518-10-19 00:08] falls asleep
[1518-04-05 00:32] wakes up
[1518-05-13 00:46] wakes up
[1518-09-17 00:52] wakes up
[1518-04-17 00:50] wakes up
[1518-11-15 00:00] Guard #1877 begins shift
[1518-06-22 00:59] wakes up
[1518-07-25 00:46] wakes up
[1518-04-30 23:48] Guard #1877 begins shift
[1518-09-12 00:03] Guard #1069 begins shift
[1518-09-21 00:54] wakes up
[1518-07-10 00:56] wakes up
[1518-03-08 00:30] wakes up
[1518-07-13 00:52] wakes up
[1518-05-23 00:44] wakes up
[1518-10-28 00:51] falls asleep
[1518-06-25 00:03] Guard #919 begins shift
[1518-10-29 00:31] wakes up
[1518-10-10 00:25] wakes up
[1518-05-23 00:58] wakes up
[1518-05-14 00:52] falls asleep
[1518-10-04 00:55] falls asleep
[1518-09-20 23:56] Guard #3319 begins shift
[1518-03-17 23:50] Guard #1093 begins shift
[1518-03-08 00:52] falls asleep
[1518-06-26 00:33] falls asleep
[1518-05-30 00:58] wakes up
[1518-05-27 23:56] Guard #3461 begins shift
[1518-05-31 00:58] wakes up
[1518-11-11 23:56] Guard #3301 begins shift
[1518-03-11 00:15] wakes up
[1518-09-14 00:58] wakes up
[1518-10-15 00:21] falls asleep
[1518-11-06 00:06] falls asleep
[1518-10-28 00:00] Guard #1877 begins shift
[1518-08-18 00:54] falls asleep
[1518-04-07 00:49] falls asleep
[1518-06-27 00:46] falls asleep
[1518-04-14 00:53] falls asleep
[1518-03-11 00:41] falls asleep
[1518-07-08 00:39] wakes up
[1518-10-04 00:03] Guard #2179 begins shift
[1518-04-06 00:57] wakes up
[1518-09-03 00:36] falls asleep
[1518-06-12 00:24] falls asleep
[1518-08-11 23:58] Guard #727 begins shift
[1518-03-18 23:59] Guard #641 begins shift
[1518-11-09 00:01] Guard #2179 begins shift
[1518-05-31 00:52] falls asleep
[1518-05-24 00:57] wakes up
[1518-05-12 00:40] falls asleep
[1518-08-24 23:59] Guard #1931 begins shift
[1518-10-15 00:03] Guard #3319 begins shift
[1518-05-04 00:21] falls asleep
[1518-10-09 00:00] Guard #1069 begins shift
[1518-09-13 00:31] falls asleep
[1518-08-25 00:35] wakes up
[1518-04-20 00:17] falls asleep
[1518-06-10 00:56] wakes up
[1518-06-05 00:37] falls asleep
[1518-10-20 23:56] Guard #1931 begins shift
[1518-09-14 23:59] Guard #2179 begins shift
[1518-10-14 00:32] wakes up
[1518-04-11 00:03] Guard #2953 begins shift
[1518-03-24 00:00] Guard #3461 begins shift
[1518-03-08 00:47] wakes up
[1518-11-19 00:07] falls asleep
[1518-07-19 00:38] falls asleep
[1518-08-22 00:40] wakes up
[1518-06-07 00:04] falls asleep
[1518-04-07 00:59] wakes up
[1518-05-24 00:44] wakes up
[1518-08-08 00:02] falls asleep
[1518-09-20 00:37] wakes up
[1518-08-03 00:35] falls asleep
[1518-03-13 23:47] Guard #3461 begins shift
[1518-06-17 00:50] wakes up
[1518-08-24 00:51] wakes up
[1518-06-02 00:26] wakes up
[1518-06-16 00:41] falls asleep
[1518-08-11 00:42] falls asleep
[1518-07-22 00:41] falls asleep
[1518-11-07 00:58] wakes up
[1518-05-08 00:03] Guard #683 begins shift
[1518-05-13 00:08] falls asleep
[1518-05-25 00:55] wakes up
[1518-11-18 00:44] wakes up
[1518-06-30 00:32] wakes up
[1518-08-07 00:40] wakes up
[1518-07-13 00:00] Guard #3079 begins shift
[1518-04-01 00:40] wakes up
[1518-03-03 23:58] Guard #3319 begins shift
[1518-09-23 00:35] wakes up
[1518-08-28 00:57] wakes up
[1518-04-15 00:52] falls asleep
[1518-05-27 00:14] falls asleep
[1518-11-07 00:13] falls asleep
[1518-03-14 23:57] Guard #3109 begins shift
[1518-10-30 00:54] wakes up
[1518-10-30 00:00] Guard #727 begins shift
[1518-08-20 00:22] falls asleep
[1518-04-01 00:04] falls asleep
[1518-03-12 00:54] wakes up
[1518-03-07 00:44] wakes up
[1518-09-26 00:39] wakes up
[1518-03-06 00:49] wakes up
[1518-10-29 00:14] falls asleep
[1518-08-25 00:28] falls asleep
[1518-09-25 00:32] falls asleep
[1518-06-06 23:47] Guard #2339 begins shift
[1518-09-19 00:34] wakes up
[1518-08-16 00:50] wakes up
[1518-10-07 00:28] wakes up
[1518-11-17 00:21] falls asleep
[1518-07-28 00:14] falls asleep
[1518-09-13 00:50] falls asleep
[1518-09-14 00:26] falls asleep
[1518-09-18 23:56] Guard #919 begins shift
[1518-03-03 00:35] falls asleep
[1518-08-31 00:03] Guard #1093 begins shift
[1518-10-19 00:00] Guard #2339 begins shift
[1518-09-28 23:59] Guard #1877 begins shift
[1518-07-11 23:58] Guard #2179 begins shift
[1518-06-19 00:56] falls asleep
[1518-10-22 00:45] wakes up
[1518-09-02 00:49] falls asleep
[1518-04-08 00:48] falls asleep
[1518-07-19 00:58] wakes up
[1518-03-07 00:36] falls asleep
[1518-05-26 00:00] Guard #919 begins shift
[1518-03-15 00:53] falls asleep
[1518-03-02 23:58] Guard #653 begins shift
[1518-07-20 00:55] wakes up
[1518-08-28 00:48] falls asleep
[1518-05-21 00:10] wakes up
[1518-08-25 23:49] Guard #1931 begins shift
[1518-03-26 23:46] Guard #1877 begins shift
[1518-08-19 00:25] falls asleep
[1518-04-22 00:03] Guard #1277 begins shift
[1518-09-08 00:54] falls asleep
[1518-04-05 00:18] falls asleep
[1518-09-14 00:46] wakes up
[1518-08-03 00:47] wakes up
[1518-07-04 00:47] wakes up
[1518-11-11 00:21] falls asleep
[1518-09-05 00:42] falls asleep
[1518-08-16 00:41] falls asleep
[1518-05-06 00:34] falls asleep
[1518-08-12 00:54] wakes up
[1518-07-20 00:15] falls asleep
[1518-09-30 00:04] Guard #3079 begins shift
[1518-10-27 00:02] falls asleep
[1518-11-09 23:56] Guard #3109 begins shift
[1518-04-14 23:56] Guard #2953 begins shift
[1518-08-28 23:48] Guard #1877 begins shift
[1518-03-16 00:38] wakes up
[1518-10-01 00:39] wakes up
[1518-08-02 23:57] Guard #971 begins shift
[1518-04-20 00:20] wakes up
[1518-08-27 00:04] Guard #3301 begins shift
[1518-03-26 00:45] wakes up
[1518-09-16 00:57] wakes up
[1518-06-02 00:51] wakes up
[1518-06-19 00:59] wakes up
[1518-09-09 00:50] wakes up
[1518-05-02 00:14] falls asleep
[1518-04-10 00:50] falls asleep
[1518-09-08 00:51] wakes up
[1518-05-02 23:58] Guard #727 begins shift
[1518-05-14 00:04] Guard #919 begins shift
[1518-08-24 00:24] falls asleep
[1518-04-13 00:18] wakes up
[1518-04-10 00:45] wakes up
[1518-08-08 00:42] falls asleep
[1518-03-26 00:27] falls asleep
[1518-04-04 00:50] falls asleep
[1518-10-01 00:03] falls asleep
[1518-05-23 00:39] falls asleep
[1518-08-25 00:59] wakes up
[1518-04-27 23:57] Guard #1117 begins shift
[1518-10-04 00:39] wakes up
[1518-08-25 00:40] falls asleep
[1518-07-17 00:40] wakes up
[1518-11-03 00:01] Guard #919 begins shift
[1518-04-02 00:27] falls asleep
[1518-09-10 00:19] falls asleep
[1518-06-23 00:36] falls asleep
[1518-09-25 00:00] Guard #1931 begins shift
[1518-09-25 00:18] wakes up
[1518-08-12 00:47] falls asleep
[1518-04-23 00:56] wakes up
[1518-08-26 00:27] wakes up
[1518-11-16 00:29] wakes up
[1518-03-18 00:41] wakes up
[1518-06-18 00:00] Guard #2953 begins shift
[1518-11-13 00:49] wakes up
[1518-04-30 00:56] wakes up
[1518-03-28 23:57] Guard #2953 begins shift
[1518-04-06 23:59] Guard #3319 begins shift
[1518-08-14 00:59] wakes up
[1518-11-19 23:48] Guard #971 begins shift
[1518-04-10 00:43] falls asleep
[1518-06-24 00:23] wakes up
[1518-10-31 00:53] falls asleep
[1518-11-04 00:54] falls asleep
[1518-08-12 00:43] wakes up
[1518-03-13 00:52] falls asleep
[1518-07-08 23:48] Guard #3461 begins shift
[1518-11-05 00:57] wakes up
[1518-05-14 00:33] wakes up
[1518-07-24 00:58] wakes up
[1518-03-03 00:55] wakes up
[1518-05-21 00:45] falls asleep
[1518-03-12 23:58] Guard #3109 begins shift
[1518-06-27 00:07] falls asleep
[1518-10-17 00:46] falls asleep
[1518-07-21 00:55] wakes up
[1518-08-06 00:57] wakes up
[1518-09-23 00:02] falls asleep
[1518-07-14 23:58] Guard #2339 begins shift
[1518-08-07 00:00] Guard #3109 begins shift
[1518-03-14 00:19] falls asleep
[1518-11-21 00:28] falls asleep
[1518-08-21 00:55] wakes up
[1518-11-21 00:04] Guard #1931 begins shift
[1518-04-09 23:57] Guard #3079 begins shift
[1518-06-05 00:04] Guard #727 begins shift
[1518-07-19 00:39] wakes up
[1518-10-11 00:29] falls asleep
[1518-05-09 00:22] wakes up
[1518-11-01 00:57] wakes up
[1518-03-17 00:02] falls asleep
[1518-08-29 00:43] falls asleep
[1518-06-07 00:06] wakes up
[1518-07-02 00:53] falls asleep
[1518-08-06 00:54] falls asleep
[1518-10-25 00:50] falls asleep
[1518-03-13 00:42] wakes up
[1518-04-15 23:57] Guard #2953 begins shift
[1518-05-21 23:50] Guard #971 begins shift
[1518-08-26 00:04] falls asleep
[1518-09-18 00:01] Guard #1877 begins shift
[1518-04-13 23:57] Guard #683 begins shift
[1518-06-27 23:59] Guard #2953 begins shift
[1518-04-25 23:56] Guard #653 begins shift
[1518-05-28 00:07] falls asleep
[1518-06-14 00:56] wakes up
[1518-09-30 00:28] falls asleep
[1518-05-05 00:26] wakes up
[1518-05-24 00:54] falls asleep
[1518-11-16 00:05] falls asleep
[1518-07-15 00:55] wakes up
[1518-11-04 00:02] Guard #3319 begins shift
[1518-04-24 00:38] wakes up
[1518-08-08 00:39] wakes up
[1518-08-09 00:54] wakes up
[1518-10-14 00:31] falls asleep
[1518-07-12 00:44] falls asleep
[1518-10-26 00:03] Guard #2953 begins shift
[1518-05-03 23:56] Guard #641 begins shift
[1518-09-03 00:04] Guard #1069 begins shift
[1518-06-08 00:36] wakes up
[1518-11-22 00:58] wakes up
[1518-04-06 00:18] falls asleep
[1518-04-12 00:53] wakes up
[1518-04-04 00:52] wakes up
[1518-06-29 00:58] wakes up
[1518-04-19 00:36] wakes up
[1518-03-18 00:00] falls asleep
[1518-08-16 00:02] Guard #641 begins shift
[1518-09-01 00:52] wakes up
[1518-05-19 00:01] falls asleep
[1518-09-22 00:45] falls asleep
[1518-03-07 00:24] falls asleep
[1518-03-13 00:22] falls asleep
[1518-04-17 00:01] Guard #971 begins shift
[1518-04-08 00:53] wakes up
[1518-03-17 00:58] wakes up
[1518-06-11 00:16] falls asleep
[1518-06-07 23:54] Guard #3079 begins shift
[1518-11-10 23:56] Guard #3109 begins shift
[1518-07-21 00:53] falls asleep
[1518-05-20 00:52] wakes up
[1518-09-09 00:25] falls asleep
[1518-08-10 00:43] wakes up
[1518-04-17 23:59] Guard #1117 begins shift
[1518-08-07 00:55] falls asleep
[1518-05-24 00:02] Guard #3109 begins shift
[1518-08-18 00:46] wakes up
[1518-05-03 00:59] wakes up
[1518-05-20 00:50] falls asleep
[1518-10-13 00:02] falls asleep
[1518-06-02 00:43] falls asleep
[1518-05-30 00:27] falls asleep
[1518-04-19 23:57] Guard #653 begins shift
[1518-10-18 00:01] Guard #971 begins shift
[1518-04-03 00:03] Guard #3301 begins shift
[1518-11-01 00:17] falls asleep
[1518-07-27 00:49] wakes up
[1518-08-01 00:38] falls asleep
[1518-07-23 00:50] wakes up
[1518-11-10 00:44] wakes up
[1518-08-20 00:46] wakes up
[1518-10-21 00:40] falls asleep
[1518-04-09 00:48] wakes up
[1518-07-30 00:33] falls asleep
[1518-09-28 00:07] falls asleep
[1518-04-13 00:00] Guard #919 begins shift
[1518-08-19 00:57] wakes up
[1518-05-25 00:04] Guard #683 begins shift
[1518-09-14 00:04] Guard #3109 begins shift
[1518-06-28 00:58] wakes up
[1518-10-12 00:01] Guard #683 begins shift
[1518-08-11 00:34] wakes up
[1518-06-20 00:24] falls asleep
[1518-11-16 00:54] wakes up
[1518-08-02 00:43] wakes up
[1518-10-31 00:50] wakes up
[1518-03-16 00:50] wakes up
[1518-10-06 00:54] wakes up
[1518-07-17 00:20] falls asleep
[1518-03-19 00:29] wakes up
[1518-10-30 00:22] falls asleep
[1518-11-15 00:48] wakes up
[1518-08-15 00:12] falls asleep
[1518-10-06 00:41] falls asleep
[1518-05-01 00:04] falls asleep
[1518-03-31 00:15] falls asleep
[1518-08-09 23:58] Guard #1931 begins shift
[1518-06-04 00:30] falls asleep
[1518-05-22 00:08] wakes up
[1518-07-20 00:02] Guard #1877 begins shift
[1518-04-12 00:17] wakes up
[1518-08-31 00:26] wakes up
[1518-04-17 00:39] falls asleep
[1518-10-02 00:35] wakes up
[1518-07-23 00:11] falls asleep
[1518-09-26 23:58] Guard #2179 begins shift
[1518-06-06 00:39] falls asleep
[1518-08-25 00:22] wakes up
[1518-07-04 23:53] Guard #3109 begins shift
[1518-09-01 00:57] falls asleep
[1518-07-01 00:04] Guard #3301 begins shift
[1518-09-03 00:41] wakes up
[1518-09-09 23:57] Guard #971 begins shift
[1518-03-08 00:59] wakes up
[1518-09-11 00:58] wakes up
[1518-04-24 00:16] falls asleep
[1518-10-19 00:49] wakes up
[1518-10-23 00:55] falls asleep
[1518-10-27 00:10] wakes up
[1518-10-15 23:58] Guard #2953 begins shift
[1518-10-02 00:02] Guard #919 begins shift
[1518-10-23 00:56] wakes up
[1518-07-10 00:29] falls asleep
[1518-11-19 00:11] wakes up
[1518-11-07 00:27] wakes up
[1518-07-15 00:54] falls asleep
[1518-09-26 00:26] falls asleep
[1518-05-05 00:00] Guard #1931 begins shift
[1518-05-01 00:45] wakes up
[1518-10-30 00:46] wakes up
[1518-08-01 23:53] Guard #1093 begins shift
[1518-05-04 00:40] wakes up
[1518-09-04 00:43] wakes up
[1518-05-10 00:22] wakes up
[1518-07-29 00:24] falls asleep
[1518-07-21 23:56] Guard #1877 begins shift
[1518-03-09 23:46] Guard #727 begins shift
[1518-07-12 00:25] falls asleep
[1518-06-08 00:49] falls asleep
[1518-07-23 00:03] Guard #3079 begins shift
[1518-03-19 23:56] Guard #2339 begins shift
[1518-05-14 00:58] wakes up
[1518-11-03 00:47] falls asleep
[1518-09-26 00:01] Guard #3461 begins shift
[1518-07-20 00:46] falls asleep
[1518-06-03 00:12] wakes up
[1518-11-16 00:32] falls asleep
[1518-09-22 00:06] wakes up
[1518-06-16 00:49] wakes up
[1518-10-12 00:28] falls asleep
[1518-07-27 00:00] Guard #3461 begins shift
[1518-06-20 00:38] wakes up
[1518-11-18 00:32] falls asleep
[1518-03-27 00:02] falls asleep
[1518-05-10 23:50] Guard #1117 begins shift
[1518-07-27 00:43] falls asleep
[1518-03-27 00:43] falls asleep
[1518-03-23 00:56] falls asleep
[1518-06-03 00:02] falls asleep
[1518-04-29 23:56] Guard #3319 begins shift
[1518-11-04 00:57] wakes up
[1518-06-03 00:37] falls asleep
[1518-05-09 00:41] falls asleep
[1518-11-15 23:50] Guard #1069 begins shift
[1518-09-25 00:12] falls asleep
[1518-11-05 00:01] Guard #1117 begins shift
[1518-07-27 00:27] wakes up
[1518-10-18 00:34] wakes up
[1518-11-22 00:44] wakes up
[1518-08-09 00:13] falls asleep
[1518-10-07 00:01] Guard #1877 begins shift
[1518-11-03 00:52] falls asleep
[1518-05-29 00:00] Guard #1069 begins shift
[1518-10-21 00:51] falls asleep
[1518-10-08 00:25] falls asleep
[1518-07-03 23:57] Guard #2953 begins shift
[1518-07-15 00:45] wakes up
[1518-08-11 00:52] wakes up
[1518-08-14 00:00] Guard #641 begins shift
[1518-10-11 00:23] falls asleep
[1518-10-12 00:50] wakes up
[1518-06-13 00:46] wakes up
[1518-07-16 23:58] Guard #1069 begins shift
[1518-03-17 00:40] falls asleep
[1518-07-15 00:23] falls asleep
[1518-05-09 23:48] Guard #971 begins shift
[1518-11-21 23:56] Guard #727 begins shift
[1518-07-29 00:00] Guard #1093 begins shift
[1518-06-27 00:48] wakes up
[1518-11-05 00:36] wakes up
[1518-04-25 00:02] Guard #1117 begins shift
[1518-10-24 00:04] falls asleep
[1518-03-10 00:54] wakes up
[1518-05-11 00:05] falls asleep
[1518-04-18 00:10] falls asleep
[1518-07-06 00:22] falls asleep
[1518-04-26 00:55] wakes up
[1518-03-24 23:56] Guard #683 begins shift
[1518-07-12 00:56] wakes up
[1518-08-04 00:11] falls asleep
[1518-08-23 23:59] Guard #727 begins shift
[1518-08-04 00:01] Guard #2339 begins shift
[1518-07-24 00:06] falls asleep
[1518-05-20 00:20] falls asleep
[1518-08-15 00:57] wakes up
[1518-03-29 00:23] wakes up
[1518-06-01 23:56] Guard #2339 begins shift
[1518-09-27 23:56] Guard #971 begins shift
[1518-04-08 00:01] Guard #653 begins shift
[1518-05-23 00:50] falls asleep
[1518-04-04 00:36] falls asleep
[1518-06-23 00:48] wakes up
[1518-05-12 00:41] wakes up
[1518-10-12 23:48] Guard #727 begins shift
[1518-04-12 00:08] falls asleep
[1518-07-11 00:49] wakes up
[1518-03-13 00:57] wakes up
[1518-03-06 00:23] falls asleep
[1518-03-31 00:00] Guard #1093 begins shift
[1518-09-13 00:33] wakes up
[1518-09-01 00:50] falls asleep
[1518-07-07 23:57] Guard #683 begins shift
[1518-11-14 00:04] Guard #971 begins shift
[1518-06-08 23:58] Guard #3301 begins shift
[1518-10-22 23:49] Guard #3461 begins shift
[1518-07-18 00:43] falls asleep
[1518-06-30 00:16] falls asleep
[1518-10-02 00:21] falls asleep
[1518-06-13 00:08] wakes up
[1518-05-03 00:36] falls asleep
[1518-09-23 23:58] Guard #1931 begins shift
[1518-10-26 23:46] Guard #683 begins shift
[1518-10-03 00:47] wakes up
[1518-03-23 00:48] wakes up
[1518-03-22 00:44] wakes up
[1518-09-08 00:45] falls asleep
[1518-05-17 00:02] Guard #1409 begins shift
[1518-09-16 23:59] Guard #641 begins shift
[1518-06-06 00:41] wakes up
[1518-08-29 00:00] falls asleep
[1518-10-04 00:59] wakes up
[1518-03-05 00:52] wakes up
[1518-08-16 23:59] Guard #1117 begins shift
[1518-11-03 00:55] wakes up
[1518-06-10 00:32] falls asleep
[1518-08-22 23:59] Guard #2543 begins shift
[1518-10-26 00:47] wakes up
[1518-03-11 00:29] wakes up
[1518-03-09 00:08] falls asleep
[1518-08-07 23:50] Guard #971 begins shift
[1518-05-30 23:59] Guard #3319 begins shift
[1518-03-29 00:12] falls asleep
[1518-06-06 00:00] falls asleep
[1518-09-24 00:58] wakes up
[1518-08-16 00:23] falls asleep
[1518-03-15 00:55] wakes up
[1518-09-22 00:00] falls asleep
[1518-03-07 00:33] wakes up
[1518-06-11 00:29] wakes up
[1518-03-11 00:22] falls asleep
[1518-09-05 00:01] Guard #2179 begins shift
[1518-07-22 00:50] falls asleep
[1518-05-15 00:01] Guard #3109 begins shift
[1518-11-18 00:00] Guard #1069 begins shift
[1518-10-07 00:54] wakes up
[1518-09-07 00:00] Guard #2953 begins shift
[1518-05-31 23:46] Guard #1931 begins shift
[1518-08-27 23:58] Guard #1931 begins shift
[1518-09-17 00:50] falls asleep
[1518-07-17 23:52] Guard #1877 begins shift
[1518-03-09 00:00] Guard #653 begins shift
[1518-08-21 00:19] wakes up
[1518-07-24 23:49] Guard #641 begins shift
[1518-08-05 00:08] falls asleep
[1518-03-02 00:51] falls asleep
[1518-09-07 00:13] falls asleep
[1518-06-21 23:57] Guard #919 begins shift
[1518-06-11 00:59] wakes up
[1518-09-25 00:49] wakes up
[1518-05-28 00:41] wakes up
[1518-06-14 00:03] Guard #3109 begins shift
[1518-05-29 00:41] falls asleep
[1518-09-14 00:56] falls asleep
[1518-03-16 23:46] Guard #1117 begins shift
[1518-04-23 23:59] Guard #641 begins shift
[1518-09-05 00:58] wakes up
[1518-10-09 00:38] wakes up
[1518-07-10 00:02] Guard #3109 begins shift
[1518-09-13 00:52] wakes up
[1518-10-07 00:17] falls asleep
[1518-07-19 00:57] falls asleep
[1518-09-06 00:41] falls asleep
[1518-06-26 00:45] wakes up
[1518-08-19 00:03] Guard #653 begins shift
[1518-07-11 00:01] Guard #971 begins shift
[1518-11-20 00:01] falls asleep
[1518-08-30 00:03] falls asleep
[1518-11-22 00:43] falls asleep
[1518-06-08 00:00] falls asleep
[1518-04-19 00:19] falls asleep
[1518-06-23 00:00] Guard #2543 begins shift
[1518-03-18 00:52] wakes up
[1518-06-05 00:50] wakes up
[1518-05-22 00:29] falls asleep
[1518-10-17 00:06] falls asleep
[1518-06-20 00:03] Guard #2543 begins shift
[1518-08-10 23:57] Guard #3079 begins shift
[1518-06-12 00:45] falls asleep
[1518-08-17 00:30] falls asleep
[1518-08-16 00:37] wakes up
[1518-11-14 00:42] wakes up
[1518-03-19 00:19] falls asleep
[1518-08-18 00:37] falls asleep
[1518-08-11 00:12] wakes up
[1518-04-14 00:57] wakes up
[1518-05-09 00:42] wakes up
[1518-07-31 00:51] wakes up
[1518-05-08 00:40] wakes up
[1518-05-14 00:37] falls asleep
[1518-04-16 00:54] falls asleep
[1518-04-04 00:19] falls asleep
[1518-07-20 23:58] Guard #3109 begins shift
[1518-05-21 00:40] wakes up
[1518-05-21 00:16] falls asleep
[1518-10-06 00:25] falls asleep
[1518-05-10 00:05] falls asleep
[1518-05-29 00:44] wakes up
[1518-08-18 00:55] wakes up
[1518-06-18 23:58] Guard #683 begins shift
[1518-05-18 00:02] Guard #919 begins shift
[1518-06-28 23:57] Guard #683 begins shift
[1518-05-02 00:04] Guard #1877 begins shift
[1518-07-28 00:48] wakes up
[1518-11-07 00:52] falls asleep
[1518-06-22 00:30] falls asleep
[1518-05-06 00:19] wakes up
[1518-07-07 00:00] Guard #1277 begins shift
[1518-10-07 23:57] Guard #641 begins shift
[1518-07-02 00:54] wakes up
[1518-07-02 00:00] Guard #3331 begins shift
[1518-11-20 00:55] wakes up
[1518-06-16 00:03] Guard #1877 begins shift
[1518-08-21 00:09] falls asleep
[1518-09-28 00:50] wakes up
[1518-09-01 00:59] wakes up
[1518-11-23 00:53] wakes up
[1518-03-22 00:02] Guard #971 begins shift
[1518-10-24 00:58] wakes up
[1518-03-21 00:14] falls asleep
[1518-05-21 00:29] falls asleep
[1518-03-14 00:07] wakes up
[1518-02-28 23:56] Guard #971 begins shift
[1518-09-15 00:40] falls asleep
[1518-06-12 00:37] wakes up
[1518-07-18 00:51] wakes up
[1518-08-15 00:15] wakes up
[1518-11-17 00:04] Guard #641 begins shift
[1518-03-21 00:00] Guard #1877 begins shift
[1518-07-11 00:54] wakes up
[1518-11-09 00:21] falls asleep
[1518-08-29 00:32] wakes up
[1518-11-07 00:30] falls asleep
[1518-05-26 00:52] falls asleep
[1518-08-22 00:15] falls asleep
[1518-09-12 00:46] falls asleep
[1518-04-28 00:45] wakes up
[1518-07-26 00:52] wakes up
[1518-11-09 00:14] falls asleep
[1518-10-11 00:03] Guard #653 begins shift
[1518-06-02 00:20] falls asleep
[1518-05-20 23:47] Guard #727 begins shift
[1518-06-14 00:36] falls asleep
[1518-10-28 00:45] wakes up
[1518-03-28 00:16] falls asleep
[1518-04-25 00:53] wakes up
[1518-08-13 00:38] falls asleep
[1518-03-02 00:08] falls asleep
[1518-05-22 00:02] falls asleep
[1518-06-25 00:14] falls asleep
[1518-08-05 00:00] Guard #2953 begins shift
[1518-07-24 00:46] wakes up
[1518-10-10 00:14] falls asleep
[1518-04-15 00:59] wakes up
[1518-05-29 23:59] Guard #2179 begins shift
[1518-10-17 00:04] Guard #3079 begins shift
[1518-11-13 00:36] falls asleep
[1518-05-15 00:56] wakes up
[1518-05-25 00:53] falls asleep
[1518-04-06 00:00] Guard #919 begins shift
[1518-03-22 00:39] wakes up
[1518-10-28 00:40] falls asleep
[1518-09-22 00:56] wakes up
[1518-07-19 00:10] falls asleep
[1518-10-25 00:16] falls asleep
[1518-11-05 00:22] falls asleep
[1518-07-22 00:59] wakes up
[1518-08-07 00:30] falls asleep
[1518-10-05 00:36] falls asleep
[1518-03-05 00:42] falls asleep
[1518-08-23 00:23] falls asleep
[1518-03-22 00:55] wakes up
[1518-09-01 00:42] falls asleep
[1518-06-04 00:04] Guard #2179 begins shift
[1518-11-08 00:39] wakes up
[1518-04-11 00:31] falls asleep
[1518-05-12 00:03] Guard #3331 begins shift
[1518-03-31 00:49] falls asleep
[1518-07-12 00:29] wakes up
[1518-11-08 00:02] Guard #653 begins shift
[1518-03-08 00:03] Guard #727 begins shift
[1518-04-13 00:13] falls asleep
[1518-03-05 23:59] Guard #1069 begins shift
[1518-07-24 00:55] falls asleep
[1518-07-14 00:42] wakes up
[1518-05-16 00:13] falls asleep
[1518-04-25 00:26] falls asleep
[1518-10-09 23:59] Guard #641 begins shift
[1518-03-24 00:28] falls asleep
[1518-11-07 00:04] Guard #727 begins shift
[1518-06-12 00:54] wakes up
[1518-08-21 00:32] falls asleep
[1518-05-27 00:46] wakes up
[1518-06-10 00:01] Guard #683 begins shift
[1518-10-25 00:51] wakes up
[1518-10-24 23:58] Guard #3331 begins shift
[1518-03-31 23:50] Guard #2543 begins shift
[1518-04-10 00:26] falls asleep
[1518-11-21 00:58] wakes up
[1518-03-10 00:53] falls asleep
[1518-10-04 00:37] falls asleep
[1518-03-10 00:02] falls asleep
[1518-08-20 00:00] Guard #919 begins shift
[1518-08-29 00:45] wakes up
[1518-08-15 00:02] Guard #3319 begins shift
[1518-10-16 00:10] falls asleep
[1518-08-22 00:01] Guard #971 begins shift
[1518-07-11 00:06] falls asleep
[1518-10-04 23:58] Guard #919 begins shift
[1518-03-17 00:31] wakes up
[1518-09-11 00:04] Guard #1093 begins shift
[1518-05-18 00:22] falls asleep
[1518-10-14 00:57] wakes up
[1518-05-16 00:54] wakes up
[1518-03-01 00:15] falls asleep
[1518-06-15 00:42] wakes up
[1518-10-25 00:45] wakes up
[1518-10-19 23:58] Guard #971 begins shift
[1518-06-04 00:47] wakes up
[1518-05-21 00:46] wakes up
[1518-07-29 00:53] wakes up
[1518-07-03 00:20] falls asleep
[1518-05-07 00:34] wakes up
[1518-08-01 00:00] Guard #1093 begins shift
[1518-09-02 00:56] wakes up
[1518-07-06 00:38] wakes up
[1518-04-23 00:18] falls asleep
[1518-04-30 00:11] falls asleep
[1518-03-29 23:59] Guard #3461 begins shift
[1518-07-16 00:47] wakes up
[1518-06-27 00:04] Guard #1931 begins shift
[1518-08-29 23:50] Guard #3319 begins shift
[1518-11-22 23:51] Guard #3331 begins shift
[1518-06-29 00:39] falls asleep
[1518-03-08 00:12] falls asleep
[1518-06-26 00:04] Guard #653 begins shift
[1518-09-30 00:54] wakes up
[1518-07-27 00:06] falls asleep
[1518-06-29 23:57] Guard #641 begins shift
[1518-06-08 00:33] falls asleep
[1518-08-12 00:32] falls asleep
[1518-06-03 00:56] wakes up
[1518-09-07 00:40] wakes up
[1518-05-11 00:44] wakes up
[1518-11-01 00:02] Guard #1093 begins shift
[1518-09-19 23:56] Guard #919 begins shift
[1518-03-25 00:30] falls asleep
[1518-07-20 00:16] wakes up
[1518-04-26 00:54] falls asleep
[1518-08-01 00:22] wakes up
[1518-05-21 00:00] falls asleep
[1518-04-02 00:46] wakes up
[1518-11-05 23:57] Guard #919 begins shift
[1518-10-14 00:04] Guard #3109 begins shift
[1518-05-07 00:03] falls asleep
[1518-08-17 00:47] wakes up
[1518-09-19 00:08] falls asleep
[1518-03-11 00:00] falls asleep
[1518-09-22 23:52] Guard #2179 begins shift
[1518-10-13 00:36] wakes up
[1518-08-08 00:45] wakes up
[1518-03-08 00:36] falls asleep
[1518-05-06 00:03] falls asleep
[1518-07-24 00:00] Guard #3461 begins shift
[1518-05-14 00:24] falls asleep
[1518-04-04 00:42] wakes up
[1518-09-02 00:00] Guard #653 begins shift
[1518-03-16 00:46] falls asleep
[1518-08-18 00:03] Guard #727 begins shift
[1518-03-12 00:42] wakes up
[1518-04-29 00:03] Guard #1069 begins shift
[1518-05-19 00:50] wakes up
[1518-09-27 00:13] falls asleep
[1518-11-08 00:26] falls asleep
[1518-04-09 00:02] Guard #1877 begins shift
[1518-10-23 00:01] falls asleep
[1518-08-30 00:49] wakes up
[1518-09-13 00:00] Guard #1093 begins shift
[1518-04-26 23:56] Guard #1277 begins shift
[1518-11-19 00:04] Guard #3461 begins shift
[1518-07-30 00:01] Guard #919 begins shift
[1518-04-12 00:38] falls asleep
[1518-07-19 00:34] wakes up
[1518-05-23 00:03] Guard #1877 begins shift
[1518-10-06 00:36] wakes up
[1518-09-27 00:37] wakes up
[1518-03-22 00:43] falls asleep
[1518-11-06 00:45] wakes up
[1518-06-08 00:53] wakes up
[1518-05-21 00:25] wakes up
[1518-11-23 00:00] falls asleep
[1518-09-09 00:01] Guard #1093 begins shift
[1518-07-30 00:48] wakes up
[1518-09-05 23:59] Guard #3461 begins shift
[1518-07-10 00:32] wakes up
[1518-04-05 00:36] falls asleep
[1518-10-30 00:49] falls asleep
[1518-09-21 00:18] falls asleep
[1518-04-29 00:10] falls asleep
[1518-09-08 00:57] wakes up
[1518-03-30 00:59] wakes up
[1518-06-28 00:48] falls asleep
[1518-10-31 00:48] falls asleep
[1518-03-12 00:00] Guard #3079 begins shift
[1518-04-01 23:58] Guard #971 begins shift
[1518-05-26 00:55] wakes up
[1518-09-16 00:02] Guard #919 begins shift
[1518-09-10 00:29] wakes up
[1518-07-31 00:47] falls asleep
[1518-06-12 23:58] Guard #1877 begins shift
[1518-03-24 00:07] falls asleep
[1518-07-04 00:08] falls asleep
[1518-06-18 00:57] wakes up
[1518-06-21 00:02] Guard #919 begins shift
[1518-08-21 00:00] Guard #3461 begins shift
[1518-04-04 00:32] wakes up
[1518-09-11 00:13] falls asleep
[1518-10-20 00:47] wakes up
[1518-08-12 23:58] Guard #653 begins shift
[1518-09-06 00:56] wakes up";
    }

    public class Day_5
    {

        public static IEnumerable<char> GetResultPolymereChain(IEnumerable<char> chain, char? removeUnit= null)
        {
            var resultChain = new Stack<char>();
            var chainEnum = chain.GetEnumerator();
            while (chainEnum.MoveNext())
            {
                var currentPolymerUnit = chainEnum.Current;

                if (removeUnit.HasValue && Char.ToLower(removeUnit.Value) == Char.ToLower(currentPolymerUnit))
                    continue;

                if (resultChain.Count == 0) {
                    resultChain.Push(chainEnum.Current);
                    continue;
                    }

                var lastUnit = resultChain.Peek();
                if (lastUnit != currentPolymerUnit && Char.ToLower(lastUnit) == Char.ToLower(currentPolymerUnit))
                    resultChain.Pop();
                else
                    resultChain.Push(currentPolymerUnit);
            }
            return resultChain;
        }

        public static void First()
        {
            var chain = polymereChain.AsEnumerable();
            var resultChain = GetResultPolymereChain(chain);
            Console.WriteLine($"First: The resulting polymere is {resultChain.Count()} Units long.");
        }
        public static void Second()
        {
            var chain = polymereChain.AsEnumerable();
            var minChainLength = int.MaxValue;
            for(var c = 'a'; c < 'z'; c++)
            {
                var resultChain = GetResultPolymereChain(chain, c);
                if (minChainLength > resultChain.Count())
                    minChainLength = resultChain.Count();
            }
            Console.WriteLine($"Second: The resulting polymere is {minChainLength} Units long.");
        }

        public static string polymereChain = @"rpSsrRAaPgGTgGtfFoOUuRqQFhQqvVcCHzZJvbBVYydDjKkquUtTQLzZlIvVPlLOopLEelWSswzZdDbBLAPqQpaiIlOmkKeQqNnQgGzZqEJjgeDdEcCSsyYpfFPSsAzZMmhHwWmMTtaKAakAkiIKfFLWwljJzZIifFaGMHZzswWdrRDSptTNnfFRXxrxXPIwWibBeGeQqEgASsaEAaXVvrRYymMOoxOoLcRrClOFfvVocCaADdIiYNxXIoOGgUHCchuEtTeRrsSSpPOorRoOMIiPoOtTpmuTtUHhBzZbstTXxixXctrDdRPUufFVvTRraAkKkKgLlGtSBbspnNbBOGgopPtTORrohHTXJjpPQqwPprRjJWSsxSsPpbcCBSsTtfcCXMLZzlLlmxSnNRrsqWVvuUwFfQbmMIivgGVXGqQgxGgBBbVMmrRtTpPyYvQgcCGyDdYqlLFdJoOjDcnNCFpPFffpRrtTPCLSQqhHmMsgGlMmPaAMmUdDBbTiIoOkKtFfqQWpPoiIOwbwWmzZZaaAApPAlLamwWVvMzcCMQuFfUqzZlJkKjLogIiGrROrRCcJBvVbMmjsHhSzZFfHhpjtTJeEPoTaAtOAxXalLZzbBlLHhPpgfFGvKEeaAkVAaGgGPwWpgACclPpsSLapPQqXfFxBnjJVvNIDdWwIijJiSGgHnNhOoPpHfxXFiIOHhtTTtoZzhwWkYyiIJAaKkrbBbRZJjzryYgGBRjQoOqAaWwFfNkDdKLlBbncCgGKHYPpPEepZzyTUnNGguduYyNuUQqnAaUCcsSDgGOouUqrRQtZzhFfStTeEssSbvViIBjyYJeENnfFYcxXCuUPpPlLiIppPOotVyYvTeEbCcBaAmMtTwWRCHhcLlvVNnjJrZzlLDdbBaAtgGFfdOoONnoMpPmDdGdDeEgSsBbQqEeUmMuDTfHQoOqtTCuUchebBEPvVpouUbBOXxvVzZEHhVvyYYySsetiIThHQqEsSAaVNnLlnNAwHhAIiXxaNnaAWaBEeHhSsMmpPtTbusfFaASWwULlKkLlvsiISrReELlqQcgGucJjCsDdSUZrRkKzmzZmMHXxbcCBcCvVhliJjILuUhsnDdNSHpPIMmVvivRiIrVVvSsyZzXxBbWqAaQwjoOJqQYoOAaKNFfUumMvVzZnrRwUuSspJjPWNxXUunLZzlXrRcyYCSlmMLXxORlLrooiIHhOOorrRcCRSswWMjJdDsSKkTtiRrIeEWwmXaAWwxAMmdDaszGgKjKplLPUgGukzZJwWhNnHkZdTtzZzfFZgGSsDtTCYWwlLJeEjLlyRTtKeEicFfCizZvjGgOPpoJVIotTOfFIiZztTPpsSZqQTMmNeEBbkMmpPbBYEBbOMkSswWbBxBboOXKcCmObXQqmMxpPBoopOoDdOoXhHCMmcxkLlKCJjQqcCcGSsgJWwjKkWwTQqtZdDnNzBzZTFfHTtYyqQhtkKZcCzsSbrxXRpPPpBmMShHsGVvGoOggbpPIiKWwFfXvVxTvcChHVdDtmoOMZTqQeEtHgGOohzZgwWGoOwWNnzqocCCcqQdDRrOoNnmEDdLlpPwTTtzZQfFVvqbBIitwkEeKWQquUuUvuOoZzNnUtFZzfTuUeENMmbBBbUhHyyrRjJYZGwWANnPpagLlzYPwWIipfXljJLQQqXxqpPuUIiPGgpxFwkKhHLlWHhvVVoOShHsFsSffFlLBbHhIigGMoAPpahhIixXFfHYyJjOoyUuYRrWZznaAQqlLNfkKdDTtFnNPpHhfMmtTFLuUoOlyYaaAAzGgFfypPeEqQYMfVZFoOzZgGftThHzahuUHAvBhHbDdgmyYMjJwMmWGNJjnpPTKkvVPpoOtUnNFfuKbcCBkgGBbDdZlLwWYaPVvpdDAyYyGFfgzfFdDyYqiIQuUXxVvNfZkKkKzFnFsSLsoTtOSRrMmVveElRriIoSsBbiZzjJkKocHhPBbbBpCIisSBbtTcXxZzjJaAaAvVCrgGOoRhfFACcamMjZpPlLyYXRrOoNcCnwWMmxWwnNmMkKbBDoOiIMmdfUuRBbbBuIiFVXWwDdxsSvfUrFhHqQUurbBRyRzMmZrkKGPpuUhHVvSsgAnWwLuUlNuPpUeEQhiIhHHqFfPLlcCpWwaVkxXKMmvwWxXOcCjJpJjPoYqQBbGEegEJrYrRyFfAaRdAaXfFLlrRwWxDhHNnLlRkHhcCKcvVOBJjNLlnbQqcBbCJwWhHjHWwUuDdNnpsSPdDhoOERretTpoOPhHWoORrwygGYHnLzZGgHnNrFfdDAasgGIiSmFfMaAhHjJbBbBpPGQqgnNkKlLkeEGKkDdgNnnNKSskbBhHKkKepPJjEhrRDrJjRrRMmkKsOoqQJjKkSSEefFsNnyabDdBNgGnFwWOSsoAaMjJmeEtTIFfcacrRrHhRCKkBkKbkKFfhHvRrVwWVvYfFZlLrRBPpbzIioOKMmpoOPOlLpPoZzTtSKksHhAauUgGKksXxsQqvmMFOUMmGgMmubBxxXHuUAajJnNvVLBblhUuXdDwWhCcHhHShHsgGvVKkkyYKkRrdDYyfSIsSbBiAaNbFfHXxpPhBnAaXDqQdXvVxXGRWwrgxxgGeEkKaAFNnYyVvqOoDrpPpPRBbfFfoKkOCnFOofWwNcGsSrRUEBbAemMWPpBbRrZzYIiMmSrRsyPpxXbBwWwWwELlFTtzZkjNnJKffeiIEFnNHhJjqQWwLlrjJRRGxXjJaOobBAjJgpPGPpaFLlfAYySsjJRrXxsSmMdDzyeEDrRUXxzmvVMgBbtTTtGZmMueSxXsDQqdkKuEeWwEeUUucKkBbCGgjZzIfFeEOeHhEMmcCFfWwvpPVjJdDVvcmgcCGpPBbMnNCosrRzZIiLlJjFgGfUuXEzlLZehHxASsazZKTmMtkWFZzfDdwWSMmsuUulLonAaZzNmhNnHmMMfFkKFFfMmOMmuUwWjJIiYRryoXxoaAODBbhHnNUXxjoQqDdAadZzDjTtJbBuUbwWBzwOsSxXobeeEEeeEVhHKkvEsSLlOobBUuQvVqvVJjiZzxXrRCcGIiWwqxukKUoOvVzXxvVINTtnJjZOoKKkvVkWwzMCGNnyoOJYyUujLlnNYyYtTnfFrgGyYdZjJzBbsSRrlpPyKkYKkkOWwepPEoKFEecalLsStTiIoOrRBbSXMYyIiHhmxsFfcEeCvVjJOnNEenNqQdTtgGcCGgDWDdWwkKIyHhYeEvAXMmUuhHDmpPfFMVcySsYCcCvdKLldDYyGgPbWwBfFzZPppkbfXxFOOgGoQqTTttocCBfFEzKkuvVUchHCicCBbEeIhHZElLeETQzZzEUEeuHhZlLzehFfxXPpHuUZiZCUuqQuUcAawWLCcnNwJjzZWlzMGgxXmVJjZoOzmMvOogRSahHHhARjJPpjvVCcpfFPtTtTSlUlLjJZKkzuLtTfFsVvAarRkeEKJYrHhRywWxXyYbRrBKkGjJONFfoFfOAHhayYccSsCUulLsjMmAaMmzTBbtZkNgGnklLKlRZzrhHmQqIZzikKnTtUuJjNwWnwPFfpWKkNMUNeEtTHhaJjhHbBAqQbXpPzZeExqQTtHhvyYVsZIJrRjgGiDdZSAaicYFfyCIreERWwsEeDIfFpSiIswoOWdDPVviQqcCNXJjPpxFeEfXnNoOCsIiltfFTLAapPStHhdRrNnbbBBeEulLZxXzIiwWNnNOogGniIqQUsScNWwwWXVvxHhhHnuYoMmkzrCJtTjqVvQBPOWRrXoOxbBEHiOoQqmUuMAaidmMXxhXgrfFRGWwxHrRalIiLRrBbgGgGAAaCqhHQFfcCcHhHKkhCLljJcRtTkKZkKBbzIhbBHgXxuUGEezZiCtTcrFtNnqQTnNfDRwUuWrGKkgPpCgCcGjJcNnbmHhMiIyYtTSEesIiFiwWIRrCjkSGgiIUuHhzVvZaVltTLvZzIisSCAWwTtauUcHhAFzZTtFFoeEGNngNnxXfFOHWwiICczbBZLlCIicgGhiIXzZeyYEnNoOlLxiQqAaqQWHhCcaALufFUlaABbsSuvVUMhHmpkKPwCVIfDdFCxXsSkKrRcivEiEectOoVvTpOoTtPFfwWUyAaYcCuBDdMLTtAQqqQcLlCalACcpPDduUaFfKYyIiHhWyYtAZzaTpJjBXbBxdRrALOCyxXUurRWwtTYcgGocCDAalLivVkKnNfFfFJzZiKkpPnNIjIOoKkdKvVKksSIifsSFrRAaZzGgXBbfqEeQesSEFhHHhByYUuUubBgGuUqyYruUfGgFqQIbBUuRQqqVvgGKdDknVvNnhHMmsSihOIfFisSoHIjOoXxDdJDgGyYPpemMETNnOotbbQMmaAwWqTwWfFQqtuUDdCcHgGEeGxDdKkGAagDxXauUAXgGxVxXAeElMAaCcmOpaAPnNoLonNneEJjxXNRTtxXrZCvjJVQqGbxXBuULjJJjsSIilvVWiIwgCcCStwWVvoYmMynnJjNyYNnKbBAYyYZzXxyaAawOLlorHhuURXxvPpUuVBuUDdbVsBLNYynlYybIiGOYydzZznWwLlRrNZCEPpemMcEeHhmeEXDdDdJjCcxhemMPvVBOobpSsEjLZzlcSsCrRCcNnQqdDVRwWgGyYrTtONZzeEntPpHhkKaOoLQqtTiIgGcEeCPpVBbFfPpnNXxvwWPpLlPmMIiNbBnuDdwWxXURKjLlJkSsWeaAEwcozZOCNqjJuodDQqnFfNAaOUyYOFRdDrfZzRvVSsFfKVviILlkWwXKLlbBkTdDLfFExxXCAacsgGSAxXABbaaaAtQqAactLbBaehHEAkKQqiIDdNnExZcUukRrMmpPalEkOoKebYcCyBkKgAaUuPHhpWwFftmMTkKLlGRrPzZpIidlLtTfFfFDUuZsSvUJjsOoSuOoOoVvViITFftcCKkwcmIBxXbJjrjJjQqTtJnNOoRrRSjJPoOpHhGyhwDdWGgHRcCpTtoCcORrsbBZzQoaAOfeEFoOFfqRrKCaAcoKklLjJbYyBZzAzTtXbBJjzZxXQHhYXxHxXhgFfGypPpPCCcZzhHzLlyYaAAhHDdMmNnQpPlLqhiJjIKUZzucCkKKLLllkWwkMlLuUmlqQaAajJgvVGAaAQMmSuUsLlUuqtTImMBbvVxXzIibBUuwvVrRWoOlLOoNNnIinpPXxdyAajsShHVvlLJxXaAlLXFkKfIWwixWLlkKuUwXAaMmMmiUuGgIaGhjJSoOsZuUtTbBZkKEeHdDiXPpxRrLJjlIzZNnbrPBbIGgWJjwGXxyYgipNnfFeETtYyFPfFiOoIPYyppaAPELljJYygZzKkGeykMBbmJjzMmEekKlvXxVLArSDdzZqcCWJjwlLQsyAabBLlYfFvVrRPlLtTpFvVXxqISZzsdDisSLlSsFpvVMmDFfSsYVtTvwWxXiwWhwNnWHvyYVIiFfUsSuorRNfFQqAAOovVabBaVvYOkKogGNSsnUQqCcbBuUukKNiIAKkyxXYIiVvvHhVedmbBfFMDaAMXxmRrCcPpoVvAmMlcCLhHqQNDddDntTuUaJEexXlLOHmMHvVRLlraAhAsSahNJjnGXvVyYNnxDdzZoDdOgiTttLkcCgCTnAaPpbBPLlcvVCCcrRGRrbBgMBbWSlLswDdxBbIqQeEaKkgEYuUyLuUoOrRmMXEexfFfAsSfFAasSXxdMmMmPpoJjlLFfWwiIOfQwHcwQqRrWChFfWXtTxqGEzvVrKkSsRRoYyOrOTtoUcPpCNnVvuFGgPLMkEevVFffFKrwWnNZzeERTttTmlpbBoVvYjfLVvlFsTtSJvaALlWwpPhezBbZLUuOTtolKcCkPnJwWjkKrUuQqRKkgprYyPpRtTPOojJiLlIIcCNnAadxXDrLlGgVvAkKqQiwdOoqQZCctTbBzZzmMtTufFJjdlLeEzZXxZtTZzPuUDaAcCdrRFflLZzzZBbjUvydDYyYHhriJQqeEUBbGgYyQqvVHhdXxEelzZaTiIyYFftAlyHhDdDdhHBbYKCtTcdDosSOFfHhILliUtTuaAIiZzrRwkiIOotvVTNnmJjsVKkuSvVsUiIvsStTSsSBbMICczZrRJPpjjOoEHnnHhZLlODNndozDdDdRrfFZzNyYzPKeEXxkAJjjUuJaMBbJdKkDVhHJjvjNnjBbtTXxSSsAaWSswAacXHnNhZlOolLLXxrREePOovQqVItTsZzLlxZzoolLAaVvIRrGGgEeffFVvIAaiTtpPrRbsSLuGEXsnNYKkypPSzZJNncCHhjNnyoOpPYHQqKuUkAaStApqQJjPDdaTthHeVvcmeoOEMJjmGxjAatTBVBbcCixQqXIiIuURrcRNrRnrjJmMKkTtsrRTyoOYtSlSsLvVUumqQMYtrhNWwIigGAaqQhzXlaARipyYQqqQyWwYTtIiSbBFfiWwerRWwEHQqhoOhtTgGPpnBqQbNvVZzZgGVdDVPYyLlpvRrcCdlLPpJmMIDFzZflDmMdpPxXYymhHMyyYXxcCYfVoObBPZqQyYzpndDNvihRrLlHCYycbBcCItTSsudDWwdpPDKlLuUkWwKkHhiAadydAaDVxmMRZCczrecKJhHKUfWwpPBMpPNnNZbBzrVeCcgGEFfDTtdJjDAaMJIiiIjmddmMDDqLlAaQuRuUsnNSrTtQqQjJmrDdxXVvUgQYybBdYyMsSmfhRrHSsLlhqQFQqfHhLljmMJAavAwDdrnaANRWaAVUulLLZzcgGCiEeLeJjESslbBqQdDbaGgbBbdDWwBAIiNnXxgGITWwtKkgGTtiiITteWLlBbwpPXHhxyVveECckaAKWWwcDdLkKHhhHrRNnlLrQAaqbBRHhlRraAKkFiIfCLlLlTtZFfzFfLmMjJmwWMnmMNMmxDIideEkNnKKkXlLMmlLRrlhJyxXsSYjcYyiIRyYrCaAzNnJjCczalLLlkKAhBbHUuaALlcCOmMtTrRKSsknEjJZPpzKKKdDkNnTtHxXhkjJdQqDKGgxXgZvWwVvnMbBmWwSaAlPpOXxHLlTtgGaAeHhEinNqjPpJAanNQIQqSsgGzZlftTFLyYdSmsgKkXxGlSQdqQDoLsSjJlgGQyYCcMxXjzAlLauUgIimoaxXkNnQqtbRoOrxwzZWjJXypPMmmMLlYfIiFtNnlLYrRyGLhHlgaAvrfFRpPWwjAaAaJAhHqWwZzsSCgGcQgGVYyvOoNnDUuBLGgEQqBbcCfFPpZkhHKqLlLlsNwsyYSWIiTtsNnSMaAVwWvmfxXqXxFlIiEeuUuUvggGSsuvVzZiIvIzZIiiyqQYnPpNRdDkUKkuKplLVKyvVYkmrfFRmMcCtKkTMYyqdmIimCcMOaAgGNFfOoNKknLlRrdYyEeDmYyuUXGyYgvfFVEdaAGloOLoQqXWjJWCcOsqoOrRNnfFZgGzHaAusNfFnSVyrRYvdfFEehHFPpAaMmIiyaAYOQFoOUuEtTehMmHJjELleNYqLlQQaaAAqywWnoOkKbEeDdpPpPAaSwLeElGoOjJiIDdMGgRrfQqheZzEHqQDdSsxpPdkKMmQHhrWwYJjkbPpBKgNBbnnNZZzTtziHhHhVGgeByYbwReEoOVlLnpPrsSutTUZnNkRfFSsxXJjFfXxHhSFfCcsuRJjrhRrHUqWBbfFmMJDdxmmMvVMrRsiIfFTtpPWwfFSKkXYyvWDdDdHfFHjYyaAJftoHbBQqBbEeYiIQMebhHBxXFHSsfFNnjBniiIHyYMmJtTfFlcCLEersSPpzZghHEeGSAsSasKRrzZAafFRrmaAQKkcCqbBuUFANrUulLRnaPrRHhwqDdQwWBOoJjbJjxXMmWMmaIixNCcjJnXdDsSlEeAAaEeSsaQqLoIrDdRYvVZzrRESsbDdBlQMmqLwqQWJjJNnVvvVlgdDNkKTtnKkWwyyYYsARpPuUHhramMKWwYyYyDdqQXWwxCcYycCEeEMXxmhHgbBnwWhHbDdGgOoBWYywNSsQqflLFNtOojIuUiVhkSsYyKSLlCcsHWwAAaGgPpAbbBBpPbZTtGQqdnLlNgGCcUuxzdTtXIiQqxDZXUuEjNqQeMDdZzTtTeEzuUsyKkhHYSHhbzZYyqQWXxxXwqQpXxPVRrGgtTrrRYytTCcRWFfeEhHwIiaACcOozZiLPpGgYXlLxtjdbBsyfFCsSweEPpdDtduUDTOoOYyoWcrRwkKbBzZGTtTtIiVTWwSsUuVMkJjKMtsSyYkyfFSsYAiPpGbLOWOHiIhoLlgGqPcCpEeCjJQqcjqQJqZpgGqQgwWGhHPeWUMmiSsXjjhHJdDJCpcCPpPCmHhMcOZzCtCKkcIJjiNnTheEHqjhxutTMagGJbBjfFfDdOUOoRmiIeMmEMGgYWwOPfhHtTFoOpDdoWEesRHNkKnhIisWwCcDdSAaJjrkmMKCcOvjJuURrvtyYyYwWdDqRfZzFrQCcTtTBLlRrRrbGgVeGggGEuTtjJUPplxXFfLUuVyGeKbBqQqQkiIrRCsSsSsEeScRrjJYlLyUuEFfQZuUBbzgmWsSwBnNbMzZlLZSsdNkFZzooOFgCcKkGwuUWEeoOfXpPxsSqHYyejJEhHUuTtSsQqNnhyYliISstTciupPXxPFfpUZzDdFxsSvwWsSZzKIivVOSkTtuUuQqRrhMoEeCcOeJjEmHClLccCAalLGgHheEvINniVIxXdmbQLlifFYyIuUHuhHtTMmUWPpxHOoNsSxHcuUCOJxSfiITtFsXjmUuDdarRkQqKFUuUQqufKCcoOkOVIivLnORrOoofFRTFvViIfyYEOKkJMmEtTejoPFYyPoOIiBbCFfxbBXhHqQcfIgGmMVviqQAaFAOVvSOoEXmMkKaPLlpAvVlzZLfFxVYIJpPPpjiFfyveHRIuUrsSOoPWwpqQSRrsJaAjLIiliiKpKkPkLDdqIOGcIQvVXWwUuaALMmlIGcCzqrRqHxqQVYbByeMsSmEvWhHwVQqveYyUuElLSsXoOoORrrRhQZGWwgzQlCcRrWwFfdOoDKkAeEnNbBMmTtauUDYqHhHhAaIaXPVvVAaPVvyoOYnDCcsgPSspaAKkGBmWwMXcMmCxvVXZzvVSnNUSsOxXoQqRCcSseBbwWNVvjJPpnbBOyeJjKgTgGvVXoObOoxcCXBxhUuezqVvHEMmeafFAlzZEelLLicnHBbQqhHKxXkAadDAEepPytTrVvczZUOouCRsSfBPpHhrUuYyqQuUehuaAJxXjjJeEJrRiIiLAaVvJJhHjErpeEXSsSzrRZMmNYCcDMmdvVyWwUupgGAVfSvVKkmgGCcbBkLlorRhHDdOfJExIzZigGykfyYSezZEhFfUcCkrRKSsnNtTTrIiRturIiDpPmMYydNKkZgGHhOGgobBJjsKkFfSjJjJOXxpPCxXchHSjrRcCJsssSEeimMIXxSGguCcUfFGgbBWwEeiMmFYiHhPpItTaAvwFMmfWMmEeWwGvkKSsVysSwGgdeEDvrRVWzlGgLbisSESsNJjPEeWwOoUFfuppPSsZzgAaGtTfFPuUIcCpgRrUuCcufWwWDdLlGCcgdkyYKDVviMmIewWiIQqoxpPBbRkKrXOCcIDdMmOcRrriIjJbBcFLoGgOSoOsAayYcXzZapPHYOoMJjmjtTCfFbljJIiOoyYsSLNyYjqlLQJaApayYIzGkKgZdzNQqpPPcCpnZaroRTaAoOtEeuDdUvVbBsbKkBEeNgGnraACcMmHhyEOoTtyYebBDiIjJALDWQqMXBbxmfcXIjJuYYyUeExNXgJjhHGZzZKkeEWwSoOykqQKEeoOjtxXzZLIilTVvaWxXwqxXlLXxvmheEeHhENnJjWwHTGgtUuLvVlhoOHRXphHPdDZgGzYIPlKeEmMFxXfBBbbMmKAaSsRfFrcCxXKrRkkKKJjkACcayfOWwSTCUuXxvVuWuFfUwSsDdWwGgCYycRsSXxaAAahHjuwQqWtTZVvDGgHIiFfXEeMTtmBbxQqyYPOyYCyYFfEeQcIfFNQqnNePpTtEeEbXxBCYyspPScsSnuUispPSCQynNZTYqSsoOQCMDdnlLhOoHjJMmwWHMpDjJdPfqDGrRgvVvhsSHFfrRUrxFfXgGiIutXxNXxnTfFURvVwWqQugbBbBFfcMHhwwWDuUNnHSsfkKJjFqQOoIyMmPpYJjitToORrhrRoyYSsmhHMZzeEeEcDJuZzNjJnRrlLHzIWXxiIwiNnZNYyRreEqBbbBAabBQoORFtTffFNnrprUXxloOlBwWPDBMbBnOkKKkouUtTVvNIRriwWcsSCAJjAtTFPpyWwUuYNnFpLlPfLlseEpPkKddDDPHhhHSOpPOwWQLlyNnYeeWwEoOrRUlLuOoiIfFEgGbYyBNEennNZOrRoYjJmQqhraLmVvMqeEQyYeiwTgGtKoOVvlLkHhDRNhvcnkFfKBbVvVeEiJjIvNCAdXxCcDFeCnYuUGWwHvVhbBWpPtxXLNnKkzZwWpgGPCycCYQLydWgvNqQnrxsvVbdEeDdDBRJWwjFfQYsNLlnoqCNncMhHlokKOSnxXNsgDXpPMzsSrJNOonjcwGggGZzWdfEOnsSNVYyvDdaKkAAaUuGkBbKnhhHatTyYAKksSmMmXVvEeOTtoYPpKkUuSsyxFfXbTtLlxXBmSZrLlRXxYHhydEWEewzZaALJjHhlejmonNNLqQTtUuPjJCcEejPvrRVvVjdSQqJjsDkIZQPpVaxeElLZmLrRlIuUqSNnsQjHhQMmqMmgGJiGjVvFpPfOGXxoOUZzuZzUuovVzpPZPdEFfDYyderRCcAafpPpPAaFgjJlnNTOotYyXAagHlLlcFfCFfVsSdDxXAavVjqwaAZzWDAaiIYyhHbDphHPrRGtTiQqLSsTMQndDJjCXxDdlcCvVwsSNnEdWwvwrdAaDRKBlLiIiIxXHhRIiquUQBCTtcsfRrjpWwPmuwszZqtVvmmaNSsnJjAqQLBbhHlJkWaXxZxhvVlLHIiNngXxdVyYvDntBbXcCYynNdDUriIRYySnSeEKOjJVVvveTtYDwWeXxoOfFtCcAaiHxXKGlLgFfFsSegsCcVzsSOoZQnPWhHtTwpNiIpHzZhcEeCRsSrBbqQdDhHzmMbFSSkKstTQFfcHhCiBbIrAaPNnIipvVqgGQxXRStTilUurRkhZfYyWwbiIHiIqUsSrRQPLEiIeJjigGoOcPpCoOEelkKAaLhvnNaBbGgAEeVjwWQjkKJZEaAOovVUiImMukKEezzZCcrRLRrlvGgsddDmdWJjwQJVvXGCcQqvpPVBSsWKWwkXxUuTtLeIsSTOovkoOqQOiICbzZiaWwAINvVYyjEevkaAKEeVJuUVJjvKkntjWNnrREekRrjJoOQqKVqQAoLlCSVvsccfDdaAfFZuNgGPpnKhOXxoVvxuoWwOtTCcdQqXdxXYygLnNUuqQlHqQeETGjJPbhgGEVuUfZzzcCPpcSCaAcbBsVaAaPwcCWpRrJNnjjhHHnAaYywlLcCWNtloOLFfHOZmMIgswCJjeXxcohHjkKQqhHiIiFayYtZhdDDZsBguUdeEidDkuSoLWwEaAlLUMmPpPlLQzbBTtcCtTkKSpxOoVvtTGgymFoOWwEcCbBtuYSBhHbiIsPpuWlUetgGvVTiIlLYxXUTdOaoOTvQqVmQqMsYyjFXxHhIjJkKiwLlCcEeMZPpMxXmZsSsSPCUtTbBpVvPucvVwGTpPOotuUHgGlHFWwrNgoKYykPUivVIupOeEFkrvmMyYVabRRNPEsmMzZuUUeWwWCcrseEBRrbVvxXmMaAFMnsTSsSUaAaAMLOoYbnNiqQXxrRMmaXLlxMxXOXlyRrYcihVvUmMuUuHLyVqKkfFyAZuUfFzMmXZzKkWgMcnpPQaAvLAaIilVuxpXirRbGDdmMMCBbcBIAaiXLlpjJGQWwsyLljtFfYuUSJsSjsALaAKkUuSsmgGgpPEeHfFhjJfwWFJYaAkKNWwJjnyjCqFfdDMmLlFZzfqQoAaOTLlDaqIirjIiJPpzgfFZzeKkuQqVvGgUSsafhyYVKkRaArQVvFfqbnJJXsSxauUjaACMmyYxXDNqmrGgDdvUuWwOyxXzUaHEeuWTEegeEPKkpGtTQUuxDjJxlLhHtGGPiuPpOoUuUbBAMUofkrRlLyzZejiIWwQbBJjEiMgSsGPvQzZKkmMKTOnNoqNHiIxXPpZVvzhnaArCWwxXccCRARQqiILUlLHNtCseFCcfNnBbNzZVgGvyQXxIiUAvbBHhBnNRoOrxLLCkKqQGdDPXoOxxyYXtTSFhbBbdDFfUUuumMJjrRniINiFfNmEebTHheEeqnNhQqwWrTtNqaAQjTtIyYdhHtjXxNnhGgxXpoOPhHTtoOaEiEeqQcIeErZzPOzjBbJZDdYHhXxyLcyYbBOoqQuiIUBbnRXbFMmhgGIiATQmkQqKMqCYwWwAauUgGhHWlOAaQqICcqRZzMmrfFHIiaoOCcAeMnQqNYOqkSZzslHgGhinNJjNEeLloOWwnNoGHhyYlLgGgaeGypnNPYMoiImMrRAaHhMtTmuNeLpPAaqQWSsGowWOyYsBAmeEcNnRTqgzBSsbNzZJjbBJjnBXxqWQHhgkKGeEkiIKYXWwOCcUuaIfqQwPpsoWwFftTqQSbHhOovIOtklQqGgSbBfFyHhYSnbBbBIRbsQqpFLlTtpPdEeDxYyXxXWaAvVsJjTtjFZzfNnqQuUmRjQcsSDdACNFlLiLllLBbnkUumMLsSlqdrRvSsIiZzPqRDxuIBKkYylLkaRAmXFflLLlDdOqQtHhnNzUufFopzMmyfsEeqEBbHQrLHhtxrsSTeEtRFiVbSsBvYRrgGykKbneUfIiTtFcjZzChHcSYyIOaGggFfqQiIJtTNeYyjmIQkJnpPobfeElLwWFSsLkKtGIadtjZzJrNnTwoaAOaZSsxXzUuSqQAaQDdgxXGrPpSVAMajqQdOuUQZaDdAiIbtxqbBQPpqLJBDTjJEmMUtTdDTtKcimYQljJyYPpHQrZzjJZPaqaAgzoOZqeEgIiFfGNJRZZiIPvVRrrRpqQZlLzPpMTYyudKsqprREEesSVkKnAlmMlpPLvVmnYFfjJwsaPAapcGCcPpQqqQgWYyOoqQjkqQKqiOTtkKRrdDQzZqElLWwgqQGgGyYNVvIXxjyTtJjIiHwnzZNIfFaADXxIiMmdiwWOodDNnNWoONkKexeWXxuUeEEVveFrEebdTtKkjZzJWwnNftTkvdDuFfxXUVKFJjJjHUuhPoOpPgPcwWCfFBblLEMmethHTtMmxEnbtqyYvKkprwWAGgOorqgWGgeEiIKFuUWeEwBJjQqEeAvVqVkKzsrRSZzLuYyuUimMImHhfFMAJjSsIUuihNnskaMpRVAmMKUYyukrRuNnLlUIWmMIiwKkOBTtVvoOeVvxfFXEnKndgGVXxvrGgGHtTGbHhKeOouCaAeTtERrVvdDBqoOmLPpqQwJjxFwhHrRgiiIURruVvzSqJjKWwaAVvlsfFuqwrRWEkKKtTRrnOoaANjzZjJPjBtTxNVvnfFLlKpDefroLEelCuUcwWsqQeESQIilLbBNimXxkKMhHIIOoCEeSsMIfFGgiWwtNnAkYuUtTuUpTMmNEebZzRrFKxXSsFfASqQQhHheslJfFjWxgEKkesTDlSdDsStyaAyDdjJbTtBTvYuUpPidvSsJjVpDdPIzxXZpopPOxyYZgUpMeTtudDJNuOMmNdjJGEegkKDCcPpwQqlZHGUSskDdnNuiRrGEeMpeEaArRPnEeNHCclrjbXBhJCcrSswlLlhqAaQFBWwrTtCaaxXmpJZEPpeZWkKXYECUupPzsSZawjspPjJhHAaRuAySPphDZhTCkVvlLcCxhHmcCMTYIiPpZzypAyMRrmPGgpUvkdDGKbaTtDdDIZsSzbnNHhgiCcmMlLFfOoNnIatiITPtcCTpHhaARrvQqEeVVEaFfVvABbZjZRlLrlLQFpPkpPjbCcjJBPCcRjpPOcCBWzUKkCchHMvqKNnKPyYBbppPKuMRzZrZzibspMmdDDdyYjLSQqaAkKkKdJjWGgwwTBezGgVvZvIiVQIibgjxXCctBrKkHdBoOqTlLKRrjJnNkIAKkaiAZzqQawWqyLbBlxXMDdHhmyYjeEMsSoOZDdzqQuAfGqzZVIiAyeabByYAUvjSrRiIabBSeYyEinNvVyfFrRkKYnuWwUFfxJjOoXUuNMCWKkGwxcCXiIWgmMYoOvVoOybshnNVvHpkswWQqELlehHpsSPiIOcCcCaiqQKiKkdDKyGgDkqQNUupdLlDBGGFflOOWmuUMHhQSFKkWzZwWwQIinAaNQpPqWwAnKGgkDdqamcCrjJwWydwsSlLWDdDfFQmIjJZUznrRqIqQiCciSHfFwWnNhPpYnNmyHhjXxvbBaAxeZPvVoOuDwBGgbWwyYJTBNnqDBbdQSIWwEqgfZOpnwWVqwTvHVlggGGXInNQXDKkdHyYhnNpLLlllpPLtzDNyRrVbfksgGSezCmKrRBbyoOYKkoOoOgzAIuXxUopuUCzZdVvBXZzgGqYHyYmQgGcCQqWNnwGYygFjXtZihHIsSGwqQiYyIxXefiISsOZlkCYycloOLNkKdAduUuUuNlgGPrRJVzEeHhUUfbBlLFnnwajJEYwrReEHMHxXhHVOnNoWuwcCWMmfFUKkGYyKXxtcCIwWCcHhSKJjknNFfPFdJQqhBbtifFITgGyqBmMbVvtNOuSsnxZzvALlaIiPFfpFomWzZJQqjtVvTkiIKomLnZzNqHPgGpgGXxuDdUNrRgZzoiLlgGIRrulrAaRNnrUuaSTtsARJyXtTyYMmmMoOOBTiaAPpZzKkgDLlrcpPQIiStTfnSKDdrrMTMagGqQpUubBPAfFmFfMasSPpXzHBaAbhZHukPpERaVuOoUnvVmMzBAKBsSuDiIdbPQqcaAAIiluzeEbBeIiCcEaKkhwWhFfFJTtDAuFUXUudDHxXhCcpPgGGLFaGgAfSssSyYQXxcDyAaYOodMqQSyYgGmMBbdDpPiIMJjckfFKkKzRbgGBhHuZzuAaUzTtZoCQBbFfkkKBtTbgGmZfFznNhKoUsyMLwuUMXIikKXmyYMxLQxbWwfFBKRrgmOogGFDIidxSsXeCCccExWSOjJfFoNnXDEedDKhHQcCSMlLifXxmhHMkMhpPHdGgFfcCZtTtQqSEIieYWcNumjJMUIITtOoiEeiLSswWlOdGJjCkAanNGgPpJLyYljJjrleEZcbBCiIzOoOdKkLlsjJMmMmRdDxLlxXqUzZuQbyYgaJDMyYPGgGRmMrCFdhHyYDIMmAdDbBrVvgGHhRDCgGMmIRINnfFiwDdWWwrQwgGjJiIdFrAJjnNcCaprRXxKBHIRxTbKPXxlJRreRRrrgGCfFsUuSXiIFEefhHbklSUuZBbTtzAgjJKkPgGpiZizqYkKrRQqitTkKUguUruURzZvVqZUJBbjFfwJuinNnNmMhzbrIiKcCOokzZRRqQHAkussxXYlRAabEelqWlnWivaIinjJiIdDSFfDdKbBoOoOCcaQpPQwWOotTtTqPpMoOqdVQWwIiKkEMGhHxXOoXxPpMyoisSXKNnMBKwpUuoOZxoOXnRikbBKzZaAIrrRuCsgGpIYyiKcCkHwCqQcgkeEbyYBSMIiKkUNAaCcKLloeEPpiyYxdinNIpPDBKkdlLhHrbBTtsSCNncRYJjvVEjJKEUGgTOolFfOoDrmRZwWhrdDdqqcxHhBaATtxzZaAXJrRRkRrWwRCgGifBVvQnxXNqOHhDtvQcCqVTaiIWwZOostUUuuSsiIBlkaAbVtubBpPMIiSGgsQBbqVdAjTBvvpReXxEyYCBatcPBfZzDjjJrRVvKHlLhoRKvVwWlLVJvKYGjJgWwGgdDFfFfuUbdjJOrRKkMmjJTlOobBMmLsSxwWXdsRMyXeExkKMSLlsKwshHSWIiiLQqlNnIkbSPJGgjpsvKOokLhEeHHTeEkTtKOoINVJjXxvPpniUuyNxgVvGgGXIioOxXGgzZMmMUuIimFOxXjJeDdTaAtTQqFfmuWwRrPdaNnjHhJQCLKkDdUukAaFwWwIiGVvgJnNDVaFfCczaLqHhjZWwnTtqZzeEQMmZzgAaGpiKRrkzrYzZseAOoRTAaipPgwMqQMxXwgAoOOVssSrwJJjzZuIPpkKBbDdiWwKkmqQMhHaAWrhHRGgHiIYQqtyVlDfyfzZmHFfyUfFFfKkKkAcfMmnOTnNDCpPpFfqQBqpPQWqQElGgEeSEeFLeuUEKkJjlQwWHhJQqSeEstsPpSsCcvVSFFWwuPpUlAaCZzWwbUnNTjowsIeAZzlMzdDhHZUKzZjEeJJjoOvvVVdDZpmAWwWkbZcCqQacCZGgCpPKwWVvkqQwWatFqWWCcFkKkKVvCcNkyYdDKnzZiIxXfwAatTSsDBrdPEeLlpQqDfFPSsNnDdPkKrRzWwwWWwZYdDyNnORBEycLJarStrRjJGUIXxNniXZzxNdYltCcTLlxXgeEiIEeUGguWYywsmMZKmMGgtTkuTAaFyqVvQtFftIqpPpPVCKfnhzKkRWSsxiqoGmZWwzZmMdTcCqQxAOoxXhHOBGVaEWZhWbBwHaAljLUPpgGZkWwKOyMIimKnQSIXoZHJdDXOooOpUklqQvoMmOVgVrXiJFfoOobZIiNgTCUuUygGhHtrRQPpqTrjWwdORyygEdDqmMGpPgyDzBbSefbGgSxXNIgpmMpPPVkZGgzLljeyYEqekKECQARwMIlFoOaHhjJGgcrRCBBbwLMxXAaBEeasQwWmvEJjevfwWeEFPeFOoxAqQKvNnKNnYywqeqmyYdItkKEYyYNYNQwWpuRrUwWYmMgGWetTEtDdmvOeEPVgGvXjJlwAamMBbdzoOZEjJMmLSslZzDdyYJWwXSlOzIiZyYmMDgGVvnNGLlhxXHbxIlLNFfocCKbBZtsHEejTqMrKTthZLlBWDdwgHhRrqQEQqICLlYIiTwdCUaAuhHWwcCCJjNsSnzZxNCccCnGEeRrgsCxXdDcIixSvGQGgqQgWREdGclmMdDgGLylLjJaAYMmgMkgpPoCcGgZzXPpxzOoZoolHeSzfXxKINnMxyIqQEAkKaeLqQqLlxmMRWbPpSYEpLaYyAUINhhZzlLHqQEvVOfkCQqcKlLXHUuhsnTwSZzIisEeeEtbBNnTvTaAlLvVtzaQqBbAXxacQnMgmaAeENqqZzQAabBvVyuUZkKzzGfirRZJjHBbhzDyYdcCkrDdeqQAForRRYyqaqWFfwSswkKRNnbBBbmMKkrpzwPpGgyKklgQqxxwoOWOFVvCiHSPpmIyYTrRjHhHhYyxftwWrXupxXDMmWrRcCgKkNnGsAWwAbdZzWaAbkLMsfFqUmMZGghAaxXQxXnNLtTDFfDBpTttgGTPXdDxbEeKRuUXqyYXlxCLlfLyYlFjTDOoKECOTtoMmyYqbhATTMmCnUIXxixohdZSsmMJlgxMmNnFkKXTsgtAdjZaAzZMmrRDwDHHuPGwWPMLhHwWMJjNnTtCFfIyicCJjRrXxJJeEVSFdDNnfsowWtAnNWraAIrRrfAxsJhHjIqleETtLGvVgeEQgjJXjGgyhKoOkWscCJjIiJjSHUuGeRJwiIiThvVYyfPYdDgSBbughZdIojJOiCctTfEeHMmFijJfFVvJJjlioVyANnuOvamMlmGpPKFSUlXnKkHhlLNwWhPpiIGyVeLEKxRrgYVvoVbVQWYwWavEDOKqYzmnNDdcmXNnwWwtTYyWRXcsJLvVlLSCZzcJjPQhEeHqxKcCdrRSlLyYsBHaoojAaJGrgGtbBAaqQZHkGaRbBjJUxiRroCcheIiiOehHxXEXcfKkFmucCngtpCKyYLlZcCDKkJMZVxyYSsSpFfPCkQDSfyLlxXYHhSVPAMGKRrkLLllpRNnrPzZiFfIWwgmpUWwuUYycCHheEDdsLLSsjmJDUfFVaAjrRaTtdDnBteEhwKgaZGmMzZPpYgGfiDpTVVvZzvVDdeltTwrRWjGsSrqIiHKCcXxqsKkoOKxUIOWzZqQwtSsaAwWTFfVviIWwWYyfQBbogBbeVFeqaRSsMmXxkTaSsAnUiIEevIztvVHCzmZcCcvZIzrNnGgdnNQQcMbBnjpYyTWOkHSRBwNnQXPRpCgGZzcrRCVlUoOLldUpPlxuUgGcCOrMathHhwVVvWkxUCczZOIogpPFcZMWSxXswgcUCADPLlwFVIYKrEefYyozZeleUnfAaFQqQqyYbUFKPvVuUoNnwWlLUgAIXitFflAlrROZzoLPpZhHzkAaKqQlWwLvVImMXXmMafFyYAxEKkkKfFOvVGgnNoSTtsmefhSslTtLoOVvzxXFfaCcIdVAnnHhlgjJzIiZrFfUXtTxVvsSAmMUWfSAGgzZTtdVlLOouUvJXjJQWFLlfwqxSsjyTtDKOeEokTtFfFfdaQqYyiufWMoJjOJjqgSssfHlchHidDIPpTthDFeEHdDZDvEecUoOyEbZzoLQqlLlONmsTfPkvVKqQPMkKcTacCSOougWXxDdOrYtsSkJttTmpPMJzZiVvFfiKrXxRkoSsyIpcCPERlkveEMHAwqYfFwWEeOcxWwxXOogGXCRvwWwQTTtBpPFwmMeEbsqQSRrJxJjXcWmzZyJDdLfitdJEejPpDUuhHTIygGnzZYxkxXZzKkKBbwWbojhUMmPDdvninNIiOoOSsqQbBdJjPpSKXxHOHhFfAzHeMmDvEeeEBbVpPnNqZzwGOogQqROoNnHACcXiwKkHrRlLhZqQktTtHIWKmFYyTNnvpZzzQqZPYQSNnsOhHYybnKkujVpmaKkIiAgGbTtDJjaAIvaAtmEeqKCcnNnNkITtekKERDdXfFkPVOEbirIhHIfUAaqhlhHRVrcLlDdPRrpQaxSsZzWwMYyzgRrFfhEeQNpPXqQxUuhtTFMcCzhQSEuUmmCcKkiQCcrRnNceisSqQkNnbjJBNZznDCcCXxfHhTtaApliucClrRLYyBboyMmYoOlLVVvvNwmyIcuOvViaaOoUHkEhHezZQqKNRDHbBUtTJDdfcRrkKQqOOozyYFJjoOqXtAagPpFalLKXKMCcwESAiIBIWwZYyoNnwyNnYZzWRyYqJpKkfFPphcwnmMSszCsSssuosYxgPMQTtqFMAhHFfRdDraOaeEAgGUuGJjfFUuqQNngGiIiINnUGgfwWMmsuUzZqvFJjfYSSZwWaAYyzqMcRShHHsQUuhEyrRYyFfFaYyOtqQaABTtbwVvuqxcCXLPpkhHNUMmPlQiIRbSUzZuSmttwIkXxcmEtsSeoOfFNvVnEQxXBiIBvJjjJVbbhmDGgdMeEwFbJjpeWQqBbwSarRvxunLdzQwTtVwCIKnNhHkuUjvRvfFtPpPiIEaAEwWWtrePQqpEviwPWOLlhbQlpNKjJMmWJldDWwFcCAnzZPoOXxpAaamMAOXBArqQYvVyviLlqQIJbBNSsnGLRrWtGgTiIPuUHOoemMGMNnCgsdotQznpmzKjtUQeEoUuOAWwanNLlKkWfJfZzCcerbjkClLKoQqnNKxLEekdDKmlLrRGgYyzZGTtxJwVvqpPWiIYtTyecCEwQwjyFEbOsrboOrRyTtFfYBXxiIYdJpPZarRXCsSHlRTviHJjudRyRrsNnSJsSIGgiGFfCjVAClLcxiJYyYyaDdvAaePzyYZYXcCLlsIicisSIUuPYCcyzZNnrpPRGgvlLccJjCCkAaCcaAZxmzZMfDAaZSLWpPwQLlTWwBbHYnNyyYNlKYwDDMmCccBbCmEeOoMbPpcNIKkjLlJYmaYSFfVvuUsyQwWHRksDrRdSOoIZzmExakPkVbYJvNhMQqAaeHbXkeKdDkKYykAUEKOcKkCoXtHVvQjHnNhHQNnREedDbvaLeEmiTgZGgzeqtOoWwjJYyViILEyYXQnNoVYBuUbxcCpRJjrPXBDqbRrRycoiImhOIedDEuUUuLlUVuJYLlCHXGgxBHhlrcCEekKoTfvqgGFfOnrRcdDKMmwWOTGgtRKSsSdDcWwPYTtCImrRaQMrlVFaoGMhHtTENSdDgFaAfCcLrRgGMMmqSDdzPrRfZzFMmCxnNXsaLlAQqoRtTrOHQGYykoOKKQBAapPpPpYZzKjtTfjODRoOrpPOFfVxXDdmNnWUBzzZfwWFYBmMyShZDoLXxckRBbBbZbtTDflijJYzFfuUSsFPaGgMmlBIicDdkQnPpxXNkEeKzcCQsMbBijfFnJjNGHhyYSbuUJjcZHNBLlQqbnhzVcfWIAhHeHxXaAhcZKkzCFIVSoOzHEahTuUzLlMUumkPEyaNndDHdIigwARTgVwWvxXqvWlWHhkKHbBhVYyvvOeEYAjGMsSzJMkZFRpvGLlMmzZsQqQpPaAqSgGpsPpMYyoSMjJCcDdmssKiZztTIQCcVMjJGLEWESQquRTOCpxXPJsHAsqQMEqRrQlLRcGRfpPERrEeDvgXxpOwrRSomEeQqbBakKOsXKsSkKkEezygXDLnpUzHhBbBuUJjbyFfKewkkdEeDRjOEPIfFUmRrfwWFJjqDiZzeEmuIiOkoDzZdOITvVYmsRrzhHvgGVnzZyzZrlxNnBbsxXSMcpgGjZrRcBYKJrOmJCjtdDGOCqQcTmYWwVbBGhHOXxGcDkEesaPpASrsSTtudjUGqoeEoInNAjdDJzfFQoVuQDdqLlUcmKBXxHnKkMsMhaRrrMSsgGXSEkoxMIcCoOhKMMtAayYZMmjJotTOQjJHdIzTAatEHhlLgpVsYXjWsSwYKcCkDXChJCoIiTDDPsSRuUrlHJjBbrYyRuUhLhHWQTWwVWwvQqtPMmpFfaAjJadkwKkWYytqNZKkzwWaAJTIBjJAaHJkggfVvCkgGMxYnGMBBORRrroxHhWiIwgGZkOWkJZvssbGMxXapReErvyYVQUIBbkYVTkKpIutTUKRrLlLpPTtfBbdodBSwWvVsyziPEQJjebWwfMmFYMptTPTtmteEJjJFNnxZCLxuEvfFYyVAvVAGeEgcCacKkeNndRrcCDEcjXxpyYFfXLmSsMmfTroHhwWORBuUbhVeSdDyyYQdjHPcCojGrmIipXxVvKLlFfPAapXxYGbKkTykWbBwUPtTHkywWzZnJIUbBMOHRmvVXlLdAaTXxGJxaAVBSsmrNQFfPpXxqaAlLOddDdIiNniIBbOMmytFfzaRiIYyvspPjJoIsaASSLUuUuxXJTaDeEtTXxBbIYyidxXFfZPaUISQqmbBvdDpzeeEKuUVzcqQlLcCftTuhHUFNPXnNxQgAMMiuUBCcgcFtyObvSFfhVvudDrRUHVXHhgGakKARmoYyOjOzoorhHKkmMvVbVvBhHhhHgnNCvwJfDdBbsHBbhnNNnBbkKNDmMdZzEIWTWjJFffTxeWwscCYyjJMmSEzZoOnaALlwNVRrKXXxWwrrKqCVLnJIdDArboOBROISHsaAHLlolKgGybBVvxZTyYFftzXDdxXLlbmhJOPpoyICnNbBxOoXtlRrvYqADMUuitSsdDYYwVwWpPtTjONnPzZzZGpZgWOoscRhIXIoEgGWLlgGdeiqUXTbBmTYXxtyWwMCaTlOXxotJiIjTbMmaVPhVvlUkKYyqLBGSsjOoqCcmGSsgLdZzHAGgbDTtgQxKkyzdVSsttTwWwnUGOoguuQqnNQVSjrmrRLlrDXMjHQqBjtTsfFqNGgnSsuUmiIEeOoWqQRyYjoQqLgiCaAOGVvHhlfmDvOPbBcCpxDdFZtTXcWPJjXiIGuLvcNGtuUOzXxkZzyRIiPALwoOQqkQJfXXtTrSshHMrZdnNDhkNgtTQYyqWJCKkKkIaVvFrgGSsRsXBbnmMRPLNEenPDdxOjiICwWQlEPGMaAmACaRtEdqLhHlZcIiSqZthFBpUudxcrQSweuUEcpANnCJUeEJHGgbBGudZzrkjJtTIOiFgGDulxRrXxXoOLUAMjvPFPdPDdXlxHQyYuZGsmMqQYIhHiZzRFoksBbSpguUlguYyDoZFIiwYyWfOGerjJlFmbOsqQnNTtKAzhPpHZdDZVOfFoBZKwiFBhtTODapPNUuOoIeeqQYwWyWwZzPdIfnWnrHAaqFUufxFxhHWIiMmjJMXBtHhiIVvAqXxDdNnQUJhvVztHhtbyTbBFCuXxykoBbOEzJMRrrufaybLZrHhcCRAVvaJHVNnZzvKIdBBFKyRtTVsSvQDNjJRrwTtxgpwWhWnNtiIMmVAAofFjCNgGnVvRLhvSsAfFXxQqxMSseweEWXxoEeTpQitgQbBlGBVXpPxGgazJArpjxjUlxbzhTKxOojTCwjMTZUuEdDCcnkKNbuUwWBZPSvObWQmNSrdNgeEGrlBhuxHkKhouUOhJVjJyrJYyOuqlSsLHHQjJDhPzQYyqaiOoJuUmVvkKNyQqnNwJwnNXgGxEeqnwWoDOQmLMCcmMMmUumzIjBmzZVvDIiniIGGlgGLyGgdDYmFdFSZlaywhFUPpMmdTtgeIhydDlaAOFFKkcCKkmGZIiAakYoOzZTlUpEzswWeAaWATyZzEoTSIioajkIiKnNXYyjJQqxwWDNnGjJIjHwmmNnieZsDJbZHnBbNBrROoknNJjMmhuUKNhHjJFeEkxFfXlHHZWsXxxtJjwLrzZLZzFSQlLeEbrzZRsbbBgMrqrOowEKZzyKkIvaQWygyYocCHluNnePlLXukKvVZsxGsmoOmMBGgOmxPXUyyqIxVvXaAXxWYyHVCHhnCcmBbabKxTYgcRCcuTeligGILEtUljJLfFYywcFfCbpLNJjIFfIwWXxhHjcCDdhHJXlrRLfnOnXAUbeEjGyinNsgKAaVvTFfVvgMmgGHUxkKXFeEPjJjDdqQMmaAcCBiIbxXXZvVCkzZKEklMmLVtVeEaAlcnieMpwwiIiIkjvhHZwHCchRprFnNfVvSsHMIiuVvJKkthwUPQNGBQqkVtvVfYiIHzZzPDdTuUNBTtDIWgQhwjMUCbcRjGIiDgEeJjeEGRrsKsSxXVvktTZGJwWyNhHxcCnPMmtmUcCgGCcLlcCSTCMmcvAaTDdsSmMeskYRMXoRrOxUqxkclFpPTrRwiWwmWwLmkKfFkKxVFKkfhHkWPvExliIjBZzjJgdhUIEdDmLloOdHRKzIESWkbQqzZBaBbxmAUstEeTHhwlaBzLpPQqlYyWwwAaWZOobDIyYrRDTrRkQqCXnKEGGCLltTctpCZIiLQqIYIiHTWwismMSIlFDdUuxXIiLAlVeCJYyiHhITtjXCKQbzTYBNMNkxrHfFYoiIQSyCcMMxKSsSsNnuFLlCXHprTJqrNLlSscrRACIcCJMesSyMmrccIeEyqsyYHijycmUWwFZxXzuKkUzNkKQuUwShHIsSEekMtFTtQPEepLlVvxlLXipiIPIGgYGoudzVvZIXAaxDhiakFaZzouTtUKJBbqULCeNFugvVGvVUTUzSsZBSFfsNfHYKyKkMmvytjxzrRZLlMVjCcJNnvhcCcCfyYhDOodpHhhHOMoniuOrgGHlttlLEEeeszrWpPwcCRrsUuSSuUBNndXwWxOWwRNJuGgBBkdOonjJrSsSsAaRYyzPpwYHwRuhHuZzhhYCnFfDZQqZgGoOgGSsNncIjIHUDnSzimMszZkTWoBXIAlvQlEOwSAMPfgcBxXsLliIUDaoDQddNxCamiPLaGRzZEGEegqQiIUDdWeCRStTgVZUuqXxKkYzydAvDxiJzjEGOJBbOACMmccIwpPpXrwWoOROoxOLfRSHnNhsUpPutZzmMlLyYmeMmEkHhQqGggRbUugZrRzzXpjbJbCuUkKuUkGGUuiNlxqwWMmdDbaSsFaVJPEBxKTtmdHmMqpPxXxzZpMdTtBbZxnmLLfwDQSHSTqIiFfaeYYyGDFKgGiILTBtoEJjMmzQaAqVhlafcxKpPPzcTtSiIUaUueYYyuBejjJJDdheUuEHlLEhuUVZCczTjUQqNNnniINwnNcoCrMmIPcGoWwtvdDfLOyYoOhrRWWAawotpPBbBGEuJjpPmyYMUqpYyPQRrNvViJAwWaODdHhobmHsIPFfMlNnUeEIdLlDHhcCQqUGMVvQFDkKiIdUJphmSEkCGjcGrRxcCpuUXYuZjJzfFkAaAaEEeTzJTHLhHWMCLlmMLqUPVYcXxCgGNnDdeWFWyvQgjDdnGfSCcqxXLHMmLlEAeVqaCyYOKpFBPphlEeolQlNwkpRAymMYwfFYFWwnrRkEMmeKAZsdgGImMiKoiILsDCpOoXcVKPDaBbAMHZOnEaJgGiqcvVnfMNKkyWwsSYnbjZzIiaUuAarJjspBzjtTqHQgzJuNiEvVeudDUroIihqQrAJjmCwBSKUICcxyiBbbIGZrRTtJMlajMbBmJSsALlwKkpKksqQWZcNaSxXkKbQFCPzogGdPpDuUOZMmAlFfLaHSbBIvViIFKXDjfTXCOhCMWwrgGptVUVvQqGTuDdsmMhHYHhSVTwfFWHxzsSFdiaRKWkIipCbaOqwQQizZIdmLlemMCADvMNTOlLGCcgoVvtiuCZzQVgGBVvKemQoKMiIZXxzTtmLBblkxmyfAwRrZzwiaAnNApWwPcGhHZSbIImMuaAdgdvPlMiiPlkzMmZKyWAawYBheUuAaIgGFfBeFPpfZkKdrUblBbNQAaqyUWGMjgDPpdISGgsAUkKKkGzZgkGNTIAKEekahtEDdechVAaBUFfFfiIHhsSYfFdyOoyoiVaOorlabaJjEeEegVmXxMuMmyJVUXSsuuUbGRiISshwWVrRmcpwNgzZTqeGYywfQuUSKkUhsSCspPiIiDCXCAMOLlomZdDvVPoxXoOISJIioMyYATtlGxHSZJMMQdrROogHhGDqmmjzshXgLaSsmOkKjsiDcCdOpzacxGgcdAaIbBSceEHusvqQeEVqFWGgKkgEQPptGMmIinWwWPCMvuUHeFfErgBUxuvjYUaAmMyYuUvIiGUurRAvVBALROQIiGgqoAvIOYYDyaACvVCccEdDeubAavHCPpTJekKEjAaHitnRRrfFrgGgKvFfgGVmMuaiGRrJxXCCccmgaAwGguYnUudDDdLBuRfFoODMfFmzEbibBEHbMmLpIImSiIsLpVDkKGocCQqODUkKiihHBszEehHYygfFCaIWRrWaFYMXKOokKBbfeEFkOqSsMEkbvqcUInmVdacEMDqqWQoSJUujsSsABczZgGPKwkrAIDfZXhtvsySUtgYyuvKkTbBPRmcHEgGeocxtFgtTGFhHfYyJdxkfinbyYyYCcBNzTtQvVqZshTtpcfZzqQqBOosAnCzFfwSPWLlLmjzgiBIYXaAKkiukUuBbsbWAacMhHaRHIiOUuRwWjJInUjkQqKSsZGqhQpTtPJVmMvZbPSaARZzACjJcJoOBBbPpmuUFNCQpPHaAhIZzjAeaANoOolLzNnhHhmIieEdwuUWQqpkSEesjNnJvCtTxPcdSLHhllOkoODSzakxXEoOeKfIiyWarPKWtTnLqLsSOLHkMmKQmMqbfdDPkocAQvEaehlNnHhQccCtTKkCsFgCiIcNfFJGVqQOoJjfFvqVNnYwfwEzZPpmMyvpuQlcmwlvVhtjZtSseKUykYyXdyYDxKxPwWXTtgCQCjJxXcqJgcKesMHPjuDIFfGgirXxRdfqmhHTtgurSwWsRinNuLmuUpiShMZzbBBpPjIbDPpzZdBbBScQqCsWwnuUegbTDsSuUdOdDHhwUuHolFVTOgSsCpiyYRcOCNFfxYyXnnGgeEbBJjNWkhHKnuhHJtOovHJjbUyEAuUusFfCMmZpkuUXpPCFWwwWHhALHvZMmJjeOTbtlkfdgMmyCcEAmMQtshstTqdhHWlYyLFllMNXbacCABGgbBzDmPXQhDNnMkXbepPpKkjvVQqFfvAfNnABmMQXLnXxIBqBtTbQbggXxKBbcAaBjBxXJtTPxZbBYyGBrtTGKMTrJjVvFloPlLWiCfiIFCfFBbcadDoPpWwjomMgeDdJZjIXdQqyaPpAYLlVaYeEyDdxXDVvYyYZCcyDdQzvGkKsrcEwugGergAlpzZIMAcWwXnDDcCuUqvVdSsOUjuUJuAduSlLbCGFmMfFpmPpajJsWcCoeSsLtTqViILanNlzZLixbOwtUHhuKSsNneESIZsNdkKkKuhXxBbijMmJJiCzzdNwWcyHHUAaCXxcUrWhyWBbdDjJqXxQZNDKbbUjnroDbsGgRtTFtTwgcCGxXqQWfZSTTHhLhaARoUINFfOmoPHFHmXJTYVYkyhFncCbutfnEcluQjkOjJAfsSKAInNHdZzKkiDGgUOgyfPpWwlLGgFaAqfTmKAafFisWZzqnZflLuMWwCwpOoPWYJIPpXxiIhSQbBYdDqQiCCkKRhHYEmjnNicauUQqCRGgrDdGeEgnRMgGwWmQxXrRlLOocCccCCjXPpxXxGgtRPhNyYnxciuUIrRfUzZOmMCcsSAaoEekIiwWhvVHXcCmmYtTHhsqOyhRXAagGwWKVvnmnbytZEeBqkcxcEXxvLalDdfBbLthyiAalzHhcdDPTlLqmMQCcgmMgeDdkNxcQqKtdidXxcCALWQMMmmuUqdDSMmuaMXAbBKwuUseiZkrhDMkEeKeiSsuGrRgGgHDxXGbPpJLXeQqVpuUwKvXcCMyYBblMRrIXxUuWtfLjQqJyYCKXDdQYyuTSiIsOotmryKSEFftelLEmMVoOtsgGDMmYyduMTBmQqRrMbpAaNXnYjgzSgLlGdgtApPaoOTaAJrCBcaTbQqBtAusSmYyJWHSzZsdDTtqGwPpiSbBsyYdbnOotpZhyFqrRQThKkHvKbgnqpuWHTAayYEeIijUmiIhRPwWrWbBzVJVvHsShKWWkKPmEINCaALSsvTvKeczRrxJWwpEefgGuTthGtkGSIYgJBuaxNosxXSNCcFWwXxxmMiinlPBQqWrRgGrCfFzZCcGvVytXkBAMZzNcvhDdySsjJYNGgnwiIWCcwiQYYuxpRrNnXIiMozZbMSgXSzUxpEULAahOPpGYwqAVJjaMmAEeaAiPpYkeWwWRQBbRmGBSBiIqEesfERrEeqQKibBIoOkeljJoORWToOtwlosSOWjJoOCcTXSAawCczhhLKfhHnIikHZoObBzKbhzBjGPpgdSzEIzZMMGggGWhTtJigdGnNglLiItTDdWwEeJAOqQswWtIiOeYtawESZePpZzPRIVvimMruLiItFfSslLoOytTHhKkKzeEgMuUffotTnNLOoYHGgiEgGGDcCufHWYxXALzsfDLQqlfMgxXgNdMbJiZlMxXqodOgHhGNQrRWqQhrRWwHjRrWoWwOYpPnuUrRMFfjILlAMrRmZpHdjxKkXNnNRrnJqhhFfQUojRYwWvRrjHXUvVHbWwPpWwLRYmMynDRsnMqwBoVsHhpsSGgzpPeztmJWctFfJQqXktHZBXLjzZJuJXJPoORaAajZUuAvbKkgLGgqGTIqPqQtlMmLAaORrEmXXxfcCFaDdVHlrcJOarOoRaviITwGgHPGXWLdRrDhGAaEegHlGgxuUXndqyxXYBOobpPNnfFrYkfbjJbDikRrhjkKzIiwgQqGWlBYAHhFYyUlLiIRLlKkmjJjZeKyYYDzkKZaPpzZEeAdUcftYBEeTTZvVHzOoYrRyZjzjJZBGgbutTaJjcCTkKbxZzmwXfOoXQQqhRNwNFNniDpdDuUUuEEaujYyJUgGejTtJEAinAdQqwWoHsSbeEfIbBWkzbvzvVaAatTkSoBMfLaYyAREgowWzOCcdUGLGuUdDPKPYypOfrLOpPBbolyzZSgzUqhgGQqXLxpDpfpVJmzZadfiIIooOiUuKRRAarDUghjuPpjcLlaPCiIKkbBnNWsqBbFfBPpgGbRCXDdDPUubfHTIiHhzQsQEeqaLiIlAgGCdDzjJQDeTrAcagKkpHheLVvRrqcXxJoXpKkVIivlprmMNkKxSoOfAEeieEzTtZHhcjUuwxaAXvMmVGhJjDAaPpdHnKHKkGgzVxXDdvRmRxxFjcCqKWOowNnWqQxXlaprYxXZzKZovVTgwWnCVXxlUgiIxpwNneECxzfXoVdMFeoVvOELcCxXgUukKDYkKYzZrRycUuCydocIGXxlOnNEMmedDtTJrwbBnNyYaAMWwrEeTtSsRQhAaHlLSJbhrRJiImxhHdRMQeEqRJsSsvqUNWTdDtTBbvDkKZYXqGaxXAdkXxAaKBasShiIEeDlFfpPMQSsJgblTUuEetQuLHpxXvyYABGTYdBbmMDytQqgVVvvbBLvVJjtkJmMktTVvKjKAcmYTytMtxuoLlOQRrIEDSswenNqQOiSRrsxiHrCSwLlGzPgpojJpPMmJvoOWyKmMkyEePrRwWpTBbIVvmdaQyVLTBbxXcisSYAcFfCajHMBfFSsYkJlLjLOYyhShzZFfsiokKDdaizwWCcZjNnNlWmMrpPRwvWwcpDdPEecCQkRMmUQquRxhHkvnWNbBLlYhsSUuHyXhHqQYytvVFRcCrwtwiennNFfSstTkKAaOQTNnrRtqPpoSFjlLCcWVcHhaAGHGwxXWgRDdTtObBVJsVvSgGjLrRjJlLlvOZoFSsfJMrgGxvsVBoYsSTWyYwfCGqQbIIimbxXBmaGuUqXZxXzVvBbxpnCMmZvMmPpkEZCcPhHVKkMsiuAGgpzAtjlsJjiOSVUNnuraAANfFnaAZTTtYoGgDDoQTtqnBbRMbvWVvAawXjgtDEMmexfFGgWwprRPMiXxIrhwfFWocCmuyYijNYKhxXpBbPpuKYtmMBgyYlLykEePMDdRpPgJOphufFUJNnDzZqYsIiEvHZefFEztFeQqExXMlxPJCjJCaeTtnNUXlcJjNnzXfjTyYyTthHBsSEqJjepIZYSsbkKYyDORrDFlkiOhHoPtvSHJjhzZsyKiuqPiIAmgGgcCBJjSSVzjhcCHTtKwoDdKzlLXbbmjJgNyXmKcFGGKjbBbBHhhbwWrHhRGuUgTtlLitjnwWQTKDATAatqwpddtOcDdjYyQqyYHNnZVvzcNnbBEkfFKexdyJJjxyQqSvPGHheJjTtZiDcChqcCEeDdcCzeETWwmmktTHVvYyiIIiiIimXOKAaFfesWwxTMmtsSmRASWwsHmMmfKkFSmNhjJbkMCvOqZsOoSUuasPppLlRrPSiOOQguJXxNJjnDvVUReEKdCgbBpPogbBvyMtoQqgNnTJcjMocYyCRjkygGbCznNJIiPxXCmXLJjRCckKYNZSMytfFiKoUMIdQlLMuSsaAUuPpipeoJrKKWEkYCYycZuPvRrVNldxGYZSHhsxSoAaAxXMOsWoPGVPpdeFrgCremSahSjcotrUsewelaAuUgmvqkSOmSpPTtGgbBPgVBbPrfKkzKmjZyOoYBbKkmgJahHyoVwLwUuVQwWtTWwlLbBTtGtTtDdraWnNGDhAYepKZpPAauUJjtHAAaehZsvyYifZzEQBcCbqHrRhaOoiwFoOeETtCvSEesgXxIiGCBsIwWiWwDdgJIrRbBmSTMmDdtqZBbqNoOnKDdCbLlLCMmcgGApeLlEGgfZyILFbBdBcCMmzrZzKClOdDdzrKkRHnNsYhHbykKRAarZLlbuRGgrbBmMwRJjrBbAaMvobJjBjJdoJyYFANndDaWwzZQfFqJkyPIibqksSgqnNFfcChzZSoOcaApZsQmlAahYyHfFDMmeEdGAaIiHjJhsnemiIsSgtTOAfvLRmMQqAamIiqWwAMicvDdVypOoCoOsPlLpuUkrTtojpPatTAJFfjJKnNkRLlrkCNRRXxruUroQbyYBtTGgNNnnVFeEtOWwRLbhgGcyYLgGXxloOyjxXcCUvuQqEeioHMkKOCnNYrBQdbVvyHhvOeEqxelvTzZQEGtYyIMmMTtlAZmRrMzVBdIiDrqhJqhTxkiIeuaEKxBIiHhTtCchEyYmHuUnVjyBvKpPpKAgGXeQIOoiqMnNiKrhwWZzqAaYyAxXMTsSttTUuyKkinCBDdddWykLnwtTWhtqqmMQWwlsukKUzSsdFXVvzKVpCvVHhSxypEmKkMVNnQqmMAEejIIiXavJcgGgBbxHhXjYrDMmUNnrRhIVBbtrLhCbBcgGcxAzjDyQqRSotTBefYJWAaWWwjwWXgBbqQUuMlXkPptTOkcSsKJSsBdDREFjFwUuTxXtquTkXxKvVJkZMPZzNZqiITOJjLlDYkKybBSGceEmXxgSsEhVvpsSwZQqrRwWzlIigsSjFfkKVRKkabxtDdTohHiIPxXLhHRZGgRrzrlpiINabBgGieEkKpPIfWwLjwkZHhhHzFfyYnPLqBHdDotTwpvJjVWPpIFJjfVTtRTweepTVrUuVJicWvWLVvlqZDiRrIwWlGgNUWwkKAaXVAsyYWwWwEPBfFzZeEfWHBbqTeMCAVvXxaKiYyWDdTTMssBrqLyYpMuUmunKZrRzNyYlLYDdynlBbQUQqWYCcyToAAafYuUMmeuUHqShsBbrCmQsqQsTpPtyVQSFuyIixKkXYVvgoWwmaAfmpGXybBSOUSSFBbfnnNmMNcZdtTTtDNWCHPnNjQvVrwWOXxzibaiaAWwIKGgksehHWRdDoOYyrmkxkAfaVAavAGTRTtrxwWQHhfZOooRrCFfFjuCcrRPphdlLrTtnhuAAIoUapPASnNsqQYyCiugGUYMtzZTWnTtOUsSYyILPFcdKSlLsIECqISsMuUmMMKkepPsqHPpZmNnfOoUQbBqoEeOuZzHnqEeHTtGZfFmaAXqQAqCRvONnlLgGorKkLHFfQuLlmMFMmiiRqQEeIBlLeovpKRrxAariQKkMHhTVTtFfidBaAMPAaZzvZlLzJUdDNBnNoUuqypPVtfMHbBhEekwihTKzWIxNyYNnnahrnNWJjkKQAaEeWwdkKEhaAZapoOLlPWwohTtkWwPpGgsCcDzZoZzSstTNnINVpucCHHRrhiIJOBSsJorROjXyNYcCtTFwSsWljYMwCjeEtTBeEtTmtvVTMWfjJhHbtqWJjVroKOokPbBpywWQWahmxXVKLreiMmVvVvYOIwWjJNnIvVeEjTjKMmNnUuHCchTiTtIZzyCcRORYoOydDroTtfFiIoMmXZzxwGUscCAtCmiIpkKGglLpDdFtiISqQMnBVviIeYukKCOoVbBdzMDdmhWwfdHTtjJCLhFSGQeEmwFUIApPoOtTYMmMmDasFwuauRGNnLHhNHhNaoOvDMmiAZzuUZjJyYbBsSyYHFEqQMekKJjxsSijJkKaLuFfUTQqWwlTSslLRrtLIxiaGuIdDiOpkfulLBNuwWELEeEOGgbBFzKzZsSkAaFfZRlLkyHhivfWxXAagGEepnNdacVvvEdDeVuCGPpbgGBmzoOCfyRgGrYSsspPSZzGOioumRrMXKwvVaAvWHTLUulAmRkKpPoXLShHsUuMmuDyYufFLvXxcPrKkNnTJbBjtcCpsSsScCsSIixoOqWQqbrshKFfefFEVvZMmzovXxXxVxWwXwtPGNnEegJrRNcClLmiICqoOqDGzdDZAwWCcaAagvVRcCZKkNnizVcCzZCzMZchOxXoTZaAiVuNsoOSdBDdbDLltKrAQExXtTTtGgdVvDfvEGOqFMwWmwoFfiubBXkHMmhSrRQWwkhxXPpQRRZOhHeEoLlzrHhgRrJBbLEvVVrRvPpaAvtQqPdIQqaAFGiIgyzZzZaTtAgzAmMGiIkWHTbzZwYyWiIwwWWNdJmMjDtTAKkJvudjMAaHhjJpPJoOluRrUKkFfLloOlAaSDduPaNnwRrWgGpvsFsdxXSuUsqKcsfFXvzYymjevVTtEwWdzLlkcyYPTGUuNeEUMWwfKkFCxoIsSEHGfFcCgOYyIXurAgKcCZzzZhtTzPpYylLTWwCsSpPcRgOuUOAhbdDHhkKDKkkXpGgtTsljSCPQqpgGdDxrwWMmxMCMqQZxXyQkWwEeiIRroQqdeVAWwywqvtTuUBXxvOVvygGfFGXLlkelEvjJYgHvgGzZVxLusfkgMLXxAVoUvVaKxXVvOokYvOIMmLvVEevkKWwVuUjIaAfhHhFCcDzHGgGUsGypHhFHSstIWbBjviIDLldVrEghwHYGgyYJpmMPNnxGWwkKiSBbXadDFRiRAawabWRrvViIwBTOvjiqGgUuVvoOQIjnNIGeEgYnNLljJOoiFfGgcmZzlmhHpgYyfFpqQhHBbUhhaAoOdIiWNndzJUuDaTNcCncCGSCcapPAmMtxpPfnAaNXlLbBeEGLjzeEDHOXuNctRrtbBbBaHBQckpPKYyekBAabdcCaAcLlCtJiIDRxXrHhdcCcXLTdDtKkZzxQxcCrWwkiIdjJSsdlqYcCyHtTzujJEiIeYyQSmlKBwDiIBTVvtyghHGqQYaaShHuUrRwKkLlkKZzYybBdPUxqQTthHRTMmFXJtixXPpfFPpGgBbMMmsHhhIcfoXaAXeEGLYWZPBbWQAQrOfwWfFzZaDdkKUuFfyYEnNRKIrRmMFgZIiYhHQnMGXNnxWwmNqQqQqREeryYCkWqrRQwKJjAZLllLdDVWtNSxFoecCHdDvVrRhHnXxiZzulPnNeysPgGpJNnjuUMwWmzZBBbwiIfwWFrUuXRrQlthHTrpAaPRsVvSYyqQiYIiTtLlXmikXxXxFZsmMEhLOOOOoGKmaAGCgyYDtLlTWwerwCckbJjBdmMvVDYyKGOoLlqVvgVsXDdIiSXcEecDWtXxycigGejJNndDGSjJQqmMmMsbztAaKGgNnkTtZGgzTHkRmQmMtJhSTeEzuUkOIiniXBmYAaAayMgfFobBOdzZoLsvVxjqQAaeVvDwWWLCcxpoVMTwbBylLPqnygGfFLlnyekKTivVUDduDnNMRrzZQEQWkVkaXfkKEpBbVEeEeVoMmdDOkKMMmrReEqSAbmlCcWaAdDoOPpwWPpbAMmfLiNnmWWwraYyqoIilLOcVvQJKvmMGinbBsGMmgbBBFEsNnZdAaQVvDdqYOoQcCefBbFpPGqQYYrotTDJRYFfucwWRUurUubBUutGnzBdDOjMmIxiIRveFfEFfBbpPGNnOoLKmFfMuEeLlPxjhzOkKxmMiOonDduuUUQqNsZzqCchHeENmMvVkYoCczulvaAVJvVNnLzVvwJjTtFfeAvjJgpPRrxXbqLiIfAjJaFlFfQoYeLIilEArRaymEenNMaXtDzMgOfFQTtIXlLGgwrZDdtTHNFkcvqaAQtOvVoTQQsSKkqiWwTTZzYfAatUKkzdDSsSGCcSUusLyXiIxDUAaunXxugbBTzZsHlLlLhPpKkRAjlChHYdDebropmMpIiFfRXxAqfTjJtFQabdSsaAwQMmUuqQfTnNAAaimHGghMIcRrgGoEeOzTtAzVzZvBKuUwaiIMDEedPzkumnNLalLEgGiSWOJtUuuSsBcSsDdLMmTtEefwWXQqpPxfTFfjKnNkCcqFWwfGgoOsSVLlCcvfvEeVIisOyYoLewnMmNcCJamSsMABbjQqbxXPtTpPcmDSsdMtTdtbBoLlNOoFkKMmCqQauYsShMxXFwWzZYFdLvYTDIidyeETtvVhwxXwiIWxXUMAamjdDWRSvoaGWmmBbWYyGItrawWEEeSyRLlZIPaADdNzJQmMlAfFZAAavdsSjhHWfKAOoaeyYElcqlLAllLqQLDtTPqQBSsbppRrmNnMUZzyYMoOqEeAaxXQthHEofzZkKeEGgBbyYnoNnZIizDdPpOegGJjEYzZNnBbthTtlrbBRKkVBMPipCcPIpmrRoOSOjJosmDdYmrSDnNjJtoDBrIiRerYyDCcWVoXxOvwdRwWHhEyvVkVnNjvKkYypPQqkqQjJrOkJrQqzZQWwqYxXyRjJysSYdFoObgGpGgyYCOoTuxXUAbcNnvVdDSsCcrRrMmpPCzZcPVNnFfVbtrRiEeIBiIbJaaAFfDtTMmvmVvUTvfFFfsSBuUKoOccCSspPCLbTShHzANndowKaAkcCWzHhtTIiZXxbFIVvCciIcsSrKrjVvJjbFaAfXCpPQQDRHlLbBzqQpPriIMRQqdaALKYykFMmfnNMmtNnuznNZeqQkKtTkePpyAarCccCtTvBbVTtRMTtWwWwmDbXOoIqOohHQODdknbacCABpPuPpRrJpBbPbBjmsKGWZzhiIIiPjJSkKcGgUaANzoQqIiODdPkKWkeEhHbmFfkWwOobBxkKIvmMnNVOYmgmeNnHhbBqIifGgFvzZDfFXxeCccCuUEGTtgkKQmrRZzqpPlNDdnLAsSGgNnksNAVfFIZzMmYywXxNLwQLJjBbBrLyAaIiSShHUuUKTtaKkRrhrZCczBZHlKkLqQIUvVjWuzQAavdDVbBGDcCdujTtJZzIiIbNnkKBdDZcCzuUygGQiITtIPpGasLRMTkKtEemWwrXxKBmMxXrRxONnlLuUlLoOobQVXxvgGqBcNnsSEXxWwgGACXxcajLfFpkBvVtXTtrhZzbdDkPSsRfDWUuUurRqxXHhfFicMmdaHcChfjJFzZQqifcgKktkKTGgpjJmdjzZtTABbGBtTXkKUulLriNnIPEepFfkIiSssSNnYRrWwyKCcSDoLrJjkFfKRRVvKcUugDxXoBbxXLlnCwystTSsTzDmGoOgKOoJjoOgGBbNnHhFvVgJjsSGcCKkRrImsqdDkdxKkseEwXfMJjGkIiVGTtQqgvXqldNnDxmTeEtgdCcWwDGWoOlmYSuOkHMKDdqcuUOUyYPprcnNCZRrCRrGEeYygRrmcCURrQqusmabBAVvkKCqlgtTxufNLljJnUadjfxXrRpTtPHHqQhHAKkjBbEeJnNZrRUDdLaCbBpBUyYbknNabxXZMmgRrGJjmMNvAEereHBbTthKWKkwUSsCchSJjsFOofMmGgxiIhHcCAmIoOitmRRksNFsqCRdoOoOGTtItRAarZzboxEeRHhtTGgrYjWYywqQsSqdDsSRrQnAaNLUrROJjKkGntTfFfGTtYyCcgFhWwUuQliIMXxOFfwDLldRGgrMNnOfVXhHNUoOonsSrRTLlQYRrPmRrMpHjDfpsDdXlLxiykKYPWwpTkgXxmEeMuUwlLvzZhmHhhMmWybBeAWVvNTtNuuCcZvjtTpLeEnUuUMmDaDJIijnwWKLZzzoFiCcaAbBWwiIwWIFfEyYTiIttTWgzZzTnNxHhJkIiKfKgGkgGuUgAacCdDGoOWsSAaBbWwJpPjXxmMbBwqMmMhFfyQFdDfxgDdGbDojJOcOoPkKOixXamMZeEGjJBbAaLlyGgtTYTtkMXxcZEKFBvYndZTiIPHhxbWEemMzZwFfByYOoqqlLDvVdjJQsJjSwhHtTWixLvYyxXoOhyYVtWQLlvNPozBFfbFhHGQeHhisjJbKkGaAgcCpPtjWwWdOoUWwZzpzldDLEXrRVJjfFHhqQJYMwWyWSswsnNeEILlGoOdDNngQNZuzdDOoqQijJMqcCFfNnUukPpKIiYRMBbAQWwyDNndYYpPfFQqymaAMvVNYyrRaqfsqqQgGwooPpgGLggbwccCCWZzjeEJPnKHhdYkEewMmNPEepeEnWvQqVuULlIkIBbpPAFHhmMfohOvwsSfwWFWwWFfVOooHlLVvSKACcDdaULLllSVzZvsLCFfnNclnNdDCcsSuPMmSBTHUuhtsSvFICcRrCciyYvPpVZAazfVwcmHhnZzNIsHhAsJlLVuELlYUDeErRdKEekuavQgFaUmJYqQQJjtQuUbpdDUuTtGgPDHhhRAaYkKyNnbTgGFArRaftTJGBmMSsqjJVvTtQTtPmMpqzZEPpbtWGguUDdDsCcXxlgGKkhHJXxPaAgGKkmBuOoUbiIMSiILlBIrRmvVUDdkkkQVmmMnNhHuZcvVCwbBboOoJalLAmoOUQquMZzhHrpIiJKfxXqzfYyFwWpPJdDFfEetTzOoevOoexXEAGvVBrRxXiYydAMmgGBkibBIgKKuUkqQUuWYHhywVusOnNgGolLnNQkhjJHKqSzZzZWYAUjJucCaywuUnNYaPkKmMKkHhtmvVMxXXlLKlLctIiMmHCvVczUujJrRdqQjJHsqQnNqQYdsSXpPzRjJrZxcCDarRCcUDdcCrDdSTtfFDdFeEOofJWgGAcoODdeIiyxvVwzzjPlJjLKfFbBkYyqQMaAAABbjJtTcPwWpRbfIilLHUtCcTuLLlWJjRIkKifFjHKkcCCcbxBtTJRLHhhmpPgIUpPLlKugwWOohzLeEoOBbFfWgGCcBbiInoUnjUoOEmPuGzXsXxSTpPlLUutEePYyiDIVvyVtYYTMmtGgLlTsLdtrRSGXwLSEHDdqsakuUAaYyfByYnXxBbMmtuUPXRVvsSrYyaAxyKaTHhWwmcsfFSiTtHzZwvVbBWhGgnuUNnqjTtJORFisSIEdPkXbJptTFsSrRfJfFkeQDdUHyYdDheEcCHYyhSLkQuUsQqQwWqZIQiaAuUIqGWfqQXEeWdDlMQbdDbBHhUuzZzZcUEGJfelLFfEFHhfFOojgzRrZkGgrDdSsRBELlemMgoObBjJRrhgRTtWwTtDNkNnNnNeEboNnigGavrPmARrKcCgGBorEeRObExYyXAaeRrxfFXSFHkDdKhfPqQCctTpHfFaUyYlkKPpGKkgZxXvOoQaVvxXRRrJjrbfkhHVvwGcbBCJjQRPpnNzciICXxZaKPpeETtqQkRQqPVrRPpAaQDdTWwBNeXTpGEeYdDypFfCcsSaAtTDutTUBRfwxpPXEXrRZzdDAaEnwnWhhHiIYJyYiBbnyYDdeQqoIpPKkZiIoOzQuUBbJwCqoOQRrtTdWAawzZDOWUuwoPaAkKpKkAVBbpMmPvNnSLlWwOoWERrMmecCTtZzjJjiIJyNIiIiNnMLaiINlhHyYLeEMmvzZedDPQeESkpPUuDUtWwoOmyYhfFHZzuUDqQfFdTtmMzzrjngGKcCBbkNvQqVnWwzpPZMmQOolLvVmMGQcCApzRMmyYqhLqyBbmMMIJjCtTkiBbIuoOetdhHBbIioOHhbjJgGWwVvzZCcjlQBblLXjRrJTBzqfFgTtGLluUoDJOHhoyYOoypPvvOoVVYuLlUAwWmaNnvZzskKRqsAWnNtbBRXkKxTtTDAijJgtKkbBTTyYhHOolNwlLWxXxXNnqQnAaBwWONjKqFfUuizIiZGWwgzZMtTJFfEnPuUpjQqcwWCiIGQqAoiUusJCcfFCpPKkumMENBIfXTlqyYQRZWwzpPqcChxXaAeTtGeEgtQqhHxXTVvQtkKdLlgGDzZIiTSvVFOokKrRYZzsSqQZzZPOZEeJjxXTSsoYyxMarKkhAaHAKzZSrRsmOoMbiUPpXZzdrQjtclLCiIvVVVvvISsmMSsGgGgiTFfJiIpoOpPFfGgTtxXwWVaADOoQhpPzZhHoOHLlKNKkIfnsrRScaCqJHBYyFfbhGbjJHhBgrMHcChJSpPnNKkwfXxPSCcBYiIyriNssLnNwWdDplLPKnNMmToSsiVBRrEeEesOSpPSsWOoNnQwWqzZFiKkAoxyYJjyMuUmUuBbqwQbZzZGgSsGQtrbBCMpPabjJPpfFrRcCHxXhSgvVGgwVvlOWwoAaEnLloOUZxXziIFfcSsXxCeEOmgQoaAkOoSsKOqIiEAWwRrOnsStTILKQoymwWEhLBblcCZzpBDdbfFPSsHhQivVoLAaycQhHUucSsCxXHhqAatagGHfiIBKkUqQSsuBbxUHhuAaAarNCLlyxXDdYhVvHZPpCUuczlULZzvVlulLGgoGrRgplLRiaACqQIeKkZzAVvoOHJCcTDNnBbvVEqQeHheEEZzeKuUkiJDdJjyFfYIinRtTHQEoEevVoObSsBOoOgGfFCctBMSsnIBHfstMlLmTBbpYygcoOllBbXoOUuRoOrnzZNbVLlauquUGgFZzfDmbBMdHEehJjtIikKSsTzRrZkKAaLlYnoOrRTtXxEKkELleSdxXjJDuUcTivVtTTtInhHYmMmMVvyhFfulyYrayYBbKkQssSSPptkqJjVpiImMSsarRzZAmqINnFzZfIiiQJAajIqQeqLsSlOoRrSsJUkKlLuEYKvVFOumpCyJRrjYcPqbBQisHhSIlRrLfQqFXxaIpdyYJjDgnNgTDdXxXxXdXqQZXxzJjqtwqrLlRQUhAVvuZYeEoVRMQnIidrRcJdDeEHhfFFfAaqaAQAuUjjNBvHFAEGZqhHQxXRQAbBdtpPQmjJQqMxXcGeEMDaAdTtlYyayVvTHhJZzYSPpqgPxXMSstgGTmOfFoxiICcYySsbFfmgQRrqBIxPcCLlXUqOtSsToNtTCmGKYGRrgyTtkYyXxwFfwWOoCcAaxaSsAaAaYQvEeYRrPpoZzOIOCconNeKkEilIcDdCCNnLSDdsxEeomAIdDBylmuswWUuCctSNmBbUtTuvVfSJjRwWwEvVBbJjvVuIiSepbBPpyYnrrBxXWmMwdDMmARqQYlLyZzYWwUujJjJyKfGnRfhZTtzWwSuUwWsmySUusYqQMrRLhCcnNHhgWbBNLlnpzzmdtTDKkYymMCcWoOfpPVvJSvmMVcCtLhqQHlAoDtFfYyqQRruyqQEuwYyWLBbwRrwWxXUpPyLlUTeaAfeEMYXmkKMPAaPpbBvVshHRrZoOvVqpMmvVuelOsnNUKItTFfIiDGbSaAzFlLfdjJHmmMMTtjJznCcTttTIiNTAfaAtTIJdDOlLCEcWSvwWVGizlNnLohjJpPTjJhUuJLuUlAUuvCMmOzZoZwWFverRJjFfWwNNPpnFFfAWVvwasSAafeEdnNDnyYHgGBpFfgptTPtPpecyYCHhEhGXkKaOoAyEMmeYxcCcEeJjodDOfnNFBRraAFfbvVEeUuRrCLlIipPDKkUuxgiIuUGDUXCcYvVnNWKkwbhHeHhYZzyEBZKkzybgGBkKeQqEGgHkUzFCLlOaOoMmvoxXOSswtTJTBcJjoKVtFfiElnkKNDdBbORrvVowbgxjiIqAtTaoODMDSjpvVPJBVSsvbMbBmFfVJjZoOeCczzZqonTtNOaAJHkMmKIQBbIiOoqlLlnNkKpZlLcCzqevVcCEuRlLgGrQxXhBdDFzHtZzTjJKFfaAOoLIsXxzZcTtvVYMqmWwyCqsrRfBQqZyYPqnNOovMmSfnNNnFPpyYkKHxXhFfGEfiIbrRBYykFfLlhIPAiIaQqpToOMyYmvVEDddyPpdDQqIiTgGEAaetEYTtWwgGyokoOsNsPpuHrRhxuUTbBNGCcXVvCccCzAtTEewKjMMTQKkBIibqEeQAaNnhxxXmMXwjiIhHJWHSPpBbWUMTteJjEJDdFIiLljJLWwVJjvFqHhQfJFfGggGjlGgSPXbBxpkeEMLaAlmKbPGgpgGrbTtlLiIkuJkKjUdDWVDeZBbzFnNfWLcMvTtjJjJVmKkLlrVvRNLlRrfFfFkKqXxmUuhHnNvVKktgGloOIghHdBEefFdQJDdDdsSviIfFSsaALxXMmueEwWUTtDdhGTtxXbBxXxZzgGyEeYSpPstTLlLeEGZzsSHhDpHhlLOGggbBoJgnNiIQqMzeEXMmAvqoOLtTlqQcqqQQCzVvJjiKJpjJJpVvRrlndwWGgRcCyYrDOMJAapPWwDsYyFfAaxXSzsMPpGEegwUAauxXWxxXhHuUqQMRrHNgXNnwkKWxIsDTtdSSsiBbqQIioatTAeqQmMPpbBFGgDLlCMmZAAxXaavVNnXgGxPpjRrJzRZPpoOmxdQqtTIiveEVGDdLixXImwWQzZOkKsSSHJjLluUeEgXfFvVxkKGhyqjJrhHSWwXRtTqQeEXxjtTqgGQJVnNGSsiHhIsSgGwznNJjZvVsSDUuWwhHDdYloOsSqbBHhaAhHconkKNvQqVOlTwAadDgyNcEfwWarRtTFoOfPpVYyeEHqQnznNZZzrdJNnjWIwWOowrRWEGglAdDnNKmMkUOouNnHPpWuUwhgyYGRHMqQRryiIzMmBbqlLodDAOoaoAaUuixFpPfXeEILlYSsyyYIiDdsSsgGpVvFfSZzzZyqQYyRrYfaQlLqhHxXaAambdxXAapbLPsSGgpLuaAREePDdtTnhvVUjdqkKHhQCOlZzIiUuLtTdEevVWYymCbBpPbeEBzZmMrBbAaRGYgGyWwVdIkKidgWSpAaPsfcCUuFwpNnyYmMOoMmPLjJlGDMUuLlJjSsmHZwWzhjOoJaATCcgGrRtpPQrRFmgUuoOnbPpMmBNGhqQNtThHnNmcdDGgyPptzYqqcOoBbopGghdbBQqzRrVaAvUJrNMmOclgGLConUvVpJiIjPFfctJjtTsWwnNoUmXOoxCciIyYMQqjnPpJjNJuIsSikUuAaKdDbBKkQqDdFvVVvYkeEpxXuUWGgwPSsAaFzZfZjThHttTlLKkKkRBbPprJzkaALsBbSpaAkKuUQqiyuUnNmMxrCcMVCcrRsjJSQSuJjhHUsyYAJYqQUhHTtuWwCcRMmrsdDAgGazxgGnXUfFuCcuBsSbDdykKTtBbuQqUoOUixCFpPGtTgwdJzdDqQZjuUlKkPpeEmMaKkdYRSQqjJrOREemUuMAPoOpDipDdtThHCcPKkjJjhHJAPbBZaAbBzCchHoOxXnBcQqGgOTtVvonNoOmaACcMbBJyPQqphiIAQqxKktTDdTtNnjJCDdleEhsSHoEeOfWwCRKkCogGgGiIikMmQqKhHdDEdDjJeEwWwWyYGgwsSjJFUGPnNBbWXxuKkUhHweEirRIiiIgGpikuUKVHhvIsSneIBSYyJzZjyYsZwWcKkCYgwWVSsyLPplaAYCcyJjPtTpBbfOomGFfgMBbIoXxzFgGfnMmuUgVvUuGKFfkRHKkopCcPOsuFjJfUFKYXBbzZiIIYyiYyejFKgGMsFOSsorRlLDGgDdHWwdwWDhdvaPQhHqyqGgQYppPPRSJjsrnsxXxhwWHPRQqeYyHhjTtGglIIiWwJCcjjSsUsoOYySwWHhHERrmMrRLlRnNfFZiIzbFTtAaaAYacChNCSsIQqLyYTxXnNJjvVtzZlsShqQQRrbBZPpYyECoOcHhuUHyYJjtGNnkxXcCEYEkKeVOovHKqQkhbBoNnEwWrgGusbRrBxbYcWwCcCyoZooOOoOzFrRCcKkWwbqEeHEehqQQQqBfOTtRrSAadNpvUuQqrLlRpfFyYuUoOxuUAiQydLpPKkUuZmbBiIInNZziyWwYMvVOkdDKogixaAmRrMEeFfMmHhqaACcvVFfZzWwioOjJsSCeEgwWojgGJiVvQfFlIsYySIPpRufNnoOKkHheEZzJjgZlLcCzGlpYpAaPyPLpPAHUCjJkKcUuukKhpPaoOFUIiijnNZzYyJKTmMtkwCcWhbBHLlVvHQqhvaATgGtEeVAHhhHxXakKYyrhsqOoFfQoxXabByYLlpfCcxXsSpezPpZtfgGFrNloeEAMoKkhVvXneZzEhCcnNEeehHEXEeRrKCckwmMdDPphqBZzMGgOozZOodDaAKvVkDioTtwWBNnbOeEQxXqUKnNszZmnNMVvokvJTtjVfFcccgGCOoCCVvzZVjiImMJXxspPSXZOozOofICiICjJcXxXxLfFnNTtQVvpPXxKkAaOlLEefKDdTtHhEenDzYowWSsdDWwSdDwyrmMuohHfFFAmORroRGgrUuZzUXVvHWwvVJQcjJocxIrkOoKRRrYPpyuwENnjJzQrXxRhHxXQsSwWwofFsSXSsxfFlUuwWrRfFFmMfNnBhHgIugGUaKTmmcCmMvNntvgFfyYkKbBMoFdDGgfbgGBTtMmOqQSsEeGgfFmutTVvUfFDdqkoOVqQvKPplLUuHhpPLYylQGgyYfFlLJNnjvVbSsBEeWlLOoYKkDWcCwKRrkJOojdtTCcBbSpPDhzZHqQJTweEWHhgGZzYvVyylSeESscCBNnVZzSstjxXJTCcWwPBbfFUUuQquVvqQwOoWpvPpjOomMFfJbsIvyYBZtmEnJPXsSUufFxpejTtBlLCcaAlxXLOobJDggGWtvVTwLWwQqgPpGxXlmMzYyBRrmMgGjJIiaaQqqQQaARrqvJQfFapPyYpPIiSsjJmMMmAbUubkKBCcBqvtTVTndDyYGekSVvGLjeyUuiOrRlOiIoXxEcqHhQCcCdDcnZzqQNeECwWMoOmJIijIkKigGeyYgdDGLjJCqhHQcoOCcACLMmnNMmlcwWOokKVvtPpoOTpfQuUqfFJjnNYyMkFXxnNpPfOoRlzZLrRvVJjJswWSjPpjBlxXAaLbhdDIoORTtrNaOoAbkKCcaASsNnjJjJrRaAJhaHhAgGfJjEvVNnAvVzAaZWGgGgwgGPpalLmuUcPpCqyVnNNnvhzZrRZwWzOpPuUHhLlTDdESsesSkUsSuKxXVvFbBZzMmhhixCcXIvVtTwVaAjwWwJjQXFfxPprKzRNtToOvrWwXxWEvvVFfVvpmMPYySZzsIGuUyMpLlnNPxXmfnNCEkKecmMFRhHrVvwWHhRzZnNqDXsSFmgcCcCmUuYyMpPqQOoWwWkKZLlzsuQqMmqAaQlLuUUhHfqQKgGkgBbvVOBtTboPpKkGGgCgGOovVeEnDdNcFBPpfLsSlqRrlLYfFyvwWaAPrRpfkbBKFosSaAOVomMfDUzHhZhSLlHKksShlLKkYyzZsmMmMQBheEnkwWqQkKfFKNsKGgkUuWLlaAMmwHhtZziITixXIaaAEPpeMKkKBsRrOnNoSbkmYybBbRrOoyYBmMIGgiAUpPPObBopnNehHEuSHbcCSoDdwsPpMmvVcPsSpKkPIipPpkKPpOomwWMHTthCOouAaUWwSArRawCcjtTJqQxOKkarRAlLOogwWDqQeGAagxIiAaMdwWDtgGTnoMDxXQsSvyYPyYJjrlLKkVDdUEeGuNnUVLSsNnfzZQQqqQnYyNFbBvTtVqQOoKkfdDFfcCFsSpPDEednSbBQfFzetBbTXxxPpXjJlbtTLlSsdktTKFfaVTjJTRrtBTGgVvKAOMGZZzzZPpEALlaeJkKZDdzLInNilmjJqOQsSqqOqQonNXXWvVwxKkxmMYyRrstTLfyYFOoYpPySAacCntTNnwWnNVvNMsLlDCcdHrRhRfFrVvDhkKokKZMmCczpPhHqQLdUuDsrRNxlLXLlVqhHQrZzXzvVZxRzeEuUGLlcCXxeEPXxfFpWqQwsSkwTtWEOosSeCFfuUdAaDYnNTtycwWDdOvVFfUuoLfmMvVFkcCrRKwWlksoOaAHhSTvVteZCczZzNsSLTtljJouHhUtTIiZHhVvZnHhNFfHBbsSNhQqmOoMzZQOoqHhHnrRzZwlLdDYEBzZzLPplmMgGsSgGpPJjZUuIDjJdlvaVgGHFKkDqHvQqVkKeEhGupPpPmMOkKylGghHLYojJBbRtTeEmMEeWpPeEwMqUdZcCzvZsSzFhgGAaRTtOoftTFlLrHfFfRzCcxXZDdrpPBbRnmJgKkGjRrbBbukKUTaAfFrjlLJRBRrbtFEfFVvRrxXeJjuYykeEOojkMmCEiLlbBIsSDdTRrWwtcCsSPJjZzaAdDpcWwnNCGgXFHAahKkwWUufvYDSsIyDdbBwEeWVvgMJjmGWwYUFQuUHhreELleExXRqLdlMvVmLijhHgGMmnNTtDHhPpiIHhMmFfEevzZVpPoOLxXlvLlzkKiImeEKkpPMCcFuUWrRpPsSwfIiHIsPIwWrLJjxWwZhHeLlEHDduUnBfFbHRNYynLlTrvVRcCiIyVvUupPCWwvUuNnKeEkbrRJqrRQXuUvezZEfFVqQgMCEbBAaCcTCcsPpcGBbgDdxXSsChfxXFJdDjdUuDxsSeFfYFIifIiyYynNWwdDQqiEeIxXpPreEmMRvcQqCVKkaAjNndDXIixiIJPppPNnGJAgfFNnGaJYyjjFfgsSMmGggUlxXgGJjBQHqvVWwnNQKkjJrRhjCcCcuUJqFpPpPLlsSzZZzUuTPptLlgiOOlLXqQMmSicAafjJFWwCTtnNUbdDwWBxXoOTWwIiXxtucCrRbbBQZzuQkrRKTtqDdvVnNUGgqBuhHUuUpVvzgGxbBCXxsxXnpPGgNJJjmPppPhSsHhXmMxUuqQHhSsEeAZFfzaHpZAaNheNnJiXAaxhHFfDdKWiIFflLWgGLmMZSszlwkLLgGZzoOBbiIDuEejRrpxXQqPItTaIioEegGOAIivYyGgVqxXQjZxXaARgGrlLMNnIimzJcCRVuXTtOomBXxbMxYyTtxXJdDJjVvpGgyYhCcHzjJNnDUDWAaGgrRIaRjJdDiGEezlSsuULxXZNrRAakHhKLlpcCKIWwQqizZkErRVvaKkUuRrAHUjJuVYyyrTmhHFfYyMaevVtYyFfTlJQaAqKkLljLdQqmMDEAcCwbBWiIpCcCcPqQtQqOoRrROsSUuYyfzZURrNwWnuZrZzRuUwWDdegFjXzZxJMmDuUBbaFlRrkKJfFjEedDXxUueGXxTtmMOocEesSCAQqiXdFfDEempbBgGaANIitnNlLcGfReErFKtTlTGgJrRjIojnvVNOEafFIVvGtTqQgigGnwWynYyOdgGDqQTHWwhtjrRJzZLlgGZIrRQTtqkiIKiAZzazIydPfrwWkKuUOowWRQLAalfFeEcCnNftTpPeoOEJjzZrRBbRaZGgKQqYkKGgMmpmMtmTttMmTMTfGyYvVSsRzZIirOogDdRIiBuzZUgGfFyYIiWTtmMIivVYydDLlwZaALlzhzzHWwqNnSsFfQgaAAKkxZzrhQqHRuvRQqrVGYygeEUUuYILlipPyYZaAzvVDydDYNnavVAeSssSdCcDdDEZwWvVFfibdDBeELFWwuUItTifiIHcCGgaZhHBCcbpPDdKkWwPJuUjpEecqxZaOqQLlqQugGUkxUtTRlLruiZzImiIMfFUusaASsSnNAaAeEsStTaXWZznNwTtSPTkiRQqdDOBboAarWwvVIkKyYKkYycCcaAwWCPpKVvtuUrBbeESNnsYSKRrkgGsOEeokKIigDdbBcBbJjNnCwhHWYyslZzNnRrmMOoLLlnAOoaNvbBVPEefFcCoOBbKpPYykpiMCWnNlLEezHMmhaALLUuwWlZzAkKKCBbCczQqQdYyDJKRrkjaAqXemMwWKkkKcClTCQUuetTEqeYyEKkFIiSsfhHTXdUuNnDyYeMmltMmQqxrcCOzwWZpPooRrjoOJQnNkKQqnrVvDdeEzjJZGIiOogRrpNTtmecCEMnlATrRovCcJHmMMhHrRlwWLVvxXfPpFDtnNToFEefTtfuUFgXxSXxDdJjvevVEXTCctxQqQbBCcqWVvkIiIivVjAagGZzXxcCfFeEeEOoJNQqRCcrFfjJOyYWwhUiIuHdDtTMeEPpbBmTUusHPpdDhlLwWqQcCcpxXPcydDoOaAfFYxXzZzlLvVRrxXORraVQqvHhGiIgvIhHidXqQwEewWWgYZzyhBBdFfRrTFftNcmIiMCiIZzQriCtTIicRMAOoLlamSsQtTbFfKkzZOoxkEenNVvQlLqNnAEelLXxFbBfIpPigoOGaCYyLlGgdLHhlDKOokBbcfQqWOomMwQqeERrlLFxXlXxaAvBbsStTTtMmVaVFfvOCctToDdDbbBPLKkrROolWwwlLFBbfkQqsStTFuUAapPEJjeYyfFfmkKQKkAamMqOPpobiICtaATSsvVsSbBLljJIfMmRrFeSsclJjLPpNTrRtcCnHhZAaMwWmzIiyPpHKkhLlumMUYeRrcUuPPlJjLpcjJCpCEuUIfWwffJwbBYyWjstWwALUuvVlImMikjJKaTkKzZKJmIipPmMulLUDdMPDPIipdIipcKkVveBbcCEzQqZOkMmKoRrfrRBIhdDHtTMmIhKpPMmkWwRLlrWwewZzqQgGwYeEUuoOyDdMmNnwWuUWUxXuPpzZoBpPbvVpTPmMpGgtxHBbPpSIyYizZPFfpshXfqQcCFuUYJjyRrcCQqbxXJjcRZKzZLMmcCwmMMmWllSsLnNNZznNngGHhOcLlBbCtTTCctyfFUNnAWwkKbJjBaWsSwKkCbwWlOoZzHhLBwWJjDRryYTrRYytTteETgGNYynzZZzcbBxjJUuEZzNMmntaATwWewWXxnwAagNnGMmWdzCRrcDXxTtEehHdzSqQMmUMmufWRrwFmMBneEuReFfEMYgGymQqLlaAKkrYyLBbiIKHhJlLSEeFfQqsSCIijyYJnrRygCcGlLTtkKYUuNndDcCAXxYyadDsjJKCckSoTdDtqbBsSbZzDdDdBfFQbBOYyoGggrElLezZEYyesruUGvVoOjpPJIFfhHqteepQqJjPxJXxwWGghHjaUfwWFvLlVtpPfAaFIiTYyuVYyiKkwAaYyoyyVvYxXCeEBsSgQqaAGdDEebcYwUuWnNVvMmjJzZwWAZzjJCfLDsSeudDUERNaAhHhHmqQMCkKcxuUsSCcXgMYycCpPmtLlXxnNTcCavPpVZDmMtTdXxKkwWTtZeEpPjwWJvVSPpszEecCzmMJjJjAcklhHLKmiaAZAanNjiEoOeINnNHiIRbBrcChnJXUuYydDFmMfvVMTtLlzgGZmYyQgFfvagGAVlLyYbBIZzkKiIiGmMCcwWgOoWTTttmGgMGgQqWwRrPpwInxXRrNrEeRVPXuUxpQHhjJPpbbBBswWGDdgZLlzQRrqmMSQMmqVvqvBWWwkBbKbBwyYWVvdDJtTjuUWwZOXsSmMLlxMmHhEeJOouxuUAaMmUDdupPIiPpAaPZzpJsSfFjIiAaSsNCcnMmpPdRrDdDAaXzZguMuUmUGmMEeSYyxmMXsayYAkiIKdfOopPnNKkcCbDqQEedYygGBeEhwWWwUuFfHxIvViFfXjJUuyYOBblrRyYKkNnLzZUBbcCcPpCwqQNWwnvTtVSiZSsoOKkzJJjTtzZHlLhEddVvtTCSscDjVxXvJhHmFfMvcCVQkKwTtWSNnsOogGCcWwJjqYYyzZJbcCsSBjpiIPdDZAaguUraeqQugFqQiIdKEeWwLlkkxXhHsPbBpSMGgmvVrtTcCRQIiqYVvfFypPQqIBbMmHbBDbBdhivulLcLlCRrUVZMmzVvQqCuUQqqQcKktTvVIiwWKQhHBbfPOoLlpnNkhHKsFpPUaArfFRrRVvGrRqQtRrTgyYbOopPBwWXxXgwWGxcBbFfMmCZzuBKkbKQqfFoaejJEREiIerqMmQsSAKIikykdDKYTtgKkGwWffUukSsgGKFVSsIivdDWwVnNgGuUWwSSfFpPLlAaHhtBbSMmcmMCsRrwWdDTkKYyqeEwWdDMVvlLLlmQbOvVoBsyYSkvRrVVvyrRoiIOCcYynNkXxKAtTstRrdDTSYyCcCifnSsPpKXjJPpxiIcCkJjNpqQPrvVRZzRrUuAafaAFHyYdDMmhsSlLkKZzHuUyYAahHpUuTtLlxXPdTnNWwtDPGgpJjdIiDrRgGlLaSsAnidDIfHdDcChFjNnJNSQqsRrEeRQqrsMmShTtUuHhWwHhAfWwXAhHaxnNJjlfFcCXgGeEQqxLmMFhHfvVgGziMoXxOmIuUfvmMHhVLlwWqqkKQQuUuqQYyUFcSsCZNnFYOhHpPLlgBbGEeoduUnvVNJjZzwWnNEPpnzZrRjwWJaAEeHhnNNdDHhFbBfeLllLHynNZzLrQqRlXxYGgrXxRkZzKCyaAWyYwYqQcReERrgRHhrVvwWGVdDodDWwOvvVhtTlnNsSNhTtZzDdEetCGgMmfFcTYCOokKyAaMmYsSeNnyYEpPpPcRpPaAryGgBbZzNndWfFwDbBBAabEeXDbBdxaAVvMMmmWwuUbBDUujJdYsSKkyosSiICrqQJjrRmXRrxMGgpPKzZXQqxbBklLlLjmCczZndDNfFQqMyYWwjJRreVfCFfcFviIteENQqSsnyYecCXxKHhkEToOoTtzTtxXZOzsSeEacCHhLlAQMmZzqcWwqQCBbtTdaANnkKgGiIDJtTHFfAaDdlLlLFfRrpPcqQqQJfFjkKoDdORcCrhAaHtTCaTtDdzZAOlLIyYOEeGDdOogvNnVGnNgmVvkKYyZeSpPsEbBxMmuUZzgOuUaZRrsSCczVQqAavAetTEQgGvVBbqoIgGiGGgGMmXxCcggGIivVXgfFZzGlVvOoLwhHVoOvHObBhHhdAarwWRAkKnNaDUueERrlLOoHyFRrhHEeWwfYXxsIiYylLoOJjSDQqGghHdtTQeYyVwWbBvkKZgeEGzpVvPwhHWEqDlLNnrRVvdPpMmDddtIiTDxXnYoBbOyNfFIiOoXxUuVvVvSGDdgsEeVvVtGgTUXxuvXNnkKdDxmorROvuLlndrRDlYPpyyYlLgiIGmzGgZMLgGyYbBWwYyJjCcVZzWexXzZGgfFMYyQqfkKlLFVcLlCNnvOMmXxQfFQqkNcCMmLtTlrRTbIiBpdDPtOoBcCYyVvcfFCxXbxqQXzZPsYyEeMmsSSJjernNRlnNLgtTGLlUuyAaVvRrMGgzZmKrRrBbcCwWRyWwoOYnoOMrRmEetEeMJjpPmkquUIiQuzZkNnKSMaAmsUKkYykKRroOmMKgxXMgGmoOGvVzxwWXaAwWIzaAZdGguUUunNHhHLkKzQqZlhWwnNDJZWQqkKFqQfwzjJFfvVqQJMmjjHhahHAUuCcEyYeXxVvPmMEepGgHhdDqZzZzQHhcyYCTzZtGgIinyMmYJwWEQqehHjNzZsqQiIMMmmnLlNMAtTaLlluULrRyYLlIhzZHimKkqQYdgGuUDynNOonEqQeacGgAakKFEefXxCAuUWwNSBbcCyUuLXxwWlqQYwtTyYnVvNWNnktaATiIVnNiIvwWPlLYywWIiAaKkZzsSzyYZaAEecQesSEqCppLlPlLmMrcjCcJtTuUhyYHpPzYbWwJjBxXWnwWNMmSsYytTyYvVwEYyeWwxXzVWwXxvpPqIyYiQZoOyYiHhIyyYZMmxPLlpxXhHkSsVFkmMKfvGfFBbQqbBaAdDaARrdVvDPpgzDdZqQMCeoOEyYVNnvcgGgGcCLlvHDdhvYyVjJVWwuUTXxKkgGpPlLXGgSsfLldWwDCcTtRrFqQRrxuRrUGkGgKgdDkKLWwltXFfUuaAxgtrRTGCMmXxEeBbXxAiIaRrtTxXMwWRraAmeoOLlFRrjJyPpSSsssfdJjDpPFMmPpYUurRZGHhgzlLgGeEDmMdOtjJjJPpTuUoWwAgGarRGgOiIvCccCVuUoLldfsSFfjnNMqQmJEwOoWexXKkDdFEeDZzyGVvgCcuEezZwiIWxXfFwyYWpbPpWwBghHgGGzyaAYZsSFfemMwWEQqqmMQOnpnfFNfFPgGNJtTWwjdTtGzZJjgDoYyhMmHwzXxxXJjlNnLZPZzYyQqlLksSwWoOPpvIiVKlLdCUucDpWKknyQqpPfFfFsPpbLlBOoSKkjJrNnwWcChHytwWLuUlTsSYUuuUtTQPFfpqsSYylpPLiICcTtRyYMwWmnNwDdWeEhANQqxXnkKKkEdcCzZDaAeKkwlLWUgGbBuVvUSsuaeEMjJmoOoDdKkoObvYybBSsGeEgVNnBdpPNIinNnWwMsSmeEpNnqQPUeExDdfFwnNLltTWXvVEtTFfOoBbeabBARBbrcCSsiIuTtUuThGghHEakKAtTVlrRLgPpGvXxTbUutTBuUSstbgtTGpPvVBhUuYyhrRHHpaAPeBSsqwNneEbBWQbBlLuUuArRRmMraUbcYytjJmMTfFCyYHTiIZbBztSszZtDWwSsdDjJoOmMTtigGxHhLlcbaAJjBCXvSXxsSsdDVxgwnNfFWOoGXbByZzYXxf";
    }
    public class Day_6
    {
        private class Coordinate
        {
            public int no;
            public int x;
            public int y;
        }

        private class Nearest {
            public int no;
            public int dist;
            }

        public static void First()
        {
            var coords = Coordinates.Split(new[] { "\r\n" }, StringSplitOptions.None).Select(ParseCoordinate).ToList();

            var maxX = coords.Max(xy => xy.x);
            var maxY = coords.Max(xy => xy.y);

            var minX = coords.Min(xy => xy.x);
            var minY = coords.Min(xy => xy.y);

            var board = new Nearest[maxX+1, maxY+1];
            foreach (var c in coords)
            {
                for (var x = minX; x <= maxX; x++)
                {
                    for (var y = minY; y <= maxY; y++)
                    {
                        var dist = Math.Abs(y - c.y) + Math.Abs(x - c.x);

                        if (board[x, y] == null)
                        {
                            board[x, y] = new Nearest { no = c.no, dist = dist };
                        }
                        else if (board[x, y].dist == dist)
                        {
                            board[x, y].no = 0;
                        }
                        else if (board[x, y].dist > dist)
                        {
                            board[x, y].dist = dist;
                            board[x, y].no = c.no;
                        }
                    }
                }
            }

            var sizes = new int[coords.Count+1];
            for (var x = minX; x <= maxX; x++)
            {
                for (var y = minY; y <= maxY; y++)
                {
                    sizes[board[x, y].no]++;
                }
            }

            // remove infinite areas:
            for (var x = minX; x <= maxX; x++)
            {
                var c = coords.SingleOrDefault(cc => cc.no == board[x, minY].no);
                if (c != null) sizes[c.no] = 0;

                c = coords.SingleOrDefault(cc => cc.no == board[x, maxY].no);
                if (c != null) sizes[c.no] = 0;
            }
            for (var y = minY; y <= maxY; y++)
            {
                var c = coords.SingleOrDefault(cc => cc.no == board[minX, y].no);
                if (c != null) sizes[c.no] = 0;

                c = coords.SingleOrDefault(cc => cc.no == board[maxX, y].no);
                if (c != null) sizes[c.no] = 0;
            }
            var maxSize = sizes.Max();

            Console.WriteLine($"The largest area is: {maxSize}");
        }

        public static void Second()
        {
            var coords = Coordinates.Split(new[] { "\r\n" }, StringSplitOptions.None).Select(ParseCoordinate).ToList();

            var maxX = coords.Max(xy => xy.x);
            var maxY = coords.Max(xy => xy.y);

            var minX = coords.Min(xy => xy.x);
            var minY = coords.Min(xy => xy.y);

            var board = new int[maxX + 1, maxY + 1];
            foreach (var c in coords)
            {
                for (var x = minX; x <= maxX; x++)
                {
                    for (var y = minY; y <= maxY; y++)
                    {
                        var dist = Math.Abs(y - c.y) + Math.Abs(x - c.x);
                        board[x, y] += dist;
                    }
                }
            }

            var centralSize = 0;
            for (var x = minX; x <= maxX; x++)
            {
                for (var y = minY; y <= maxY; y++)
                {
                    if (board[x, y] < 10000)
                        centralSize++;
                }
            }
            Console.WriteLine($"The central area is: {centralSize}");
        }

        private static int currentNumber= 1;
        private static Coordinate ParseCoordinate(string s)
        {
            var numbers = s.Split(new [] { ", " },  StringSplitOptions.None);
            return new Coordinate {
                  no= currentNumber++,
                  x= int.Parse(numbers[0]),
                  y= int.Parse(numbers[1]),
            };
        }

        private static string Coordinates= @"132, 308
325, 300
310, 231
177, 248
111, 304
65, 135
227, 116
60, 80
182, 353
60, 42
314, 164
142, 50
90, 266
234, 219
68, 121
168, 153
258, 50
354, 92
126, 154
303, 324
90, 47
236, 316
316, 217
180, 110
70, 300
256, 221
56, 256
235, 190
56, 197
168, 145
250, 117
107, 77
259, 156
188, 301
183, 76
92, 224
41, 113
343, 90
162, 176
186, 77
312, 134
89, 98
191, 313
68, 225
85, 273
96, 161
260, 93
343, 153
247, 327
151, 197";
    }
    public class Day_7
    {

        public class Node {
            public string Name;
            public bool Visited = false;

            public List<Node> Parent = new List<Node>();
            public List<Node> After = new List<Node>();

            public void AddNode(Node other)
            {
                other.Parent.Add(this);
                After.Add(other);
            }

            public void RemoveParentNode(Node node)
            {
                Parent.Remove(node);
            }

            public void RemoveAfterNode(Node node)
            {
                After.Remove(node);
            }

            public Node GetNode(string name)
            {
                return After.SingleOrDefault(n => n.Name == name);
            }

            public string Sequence //(Node fromNode)
            {
                get {
                    if (Parent.Any(n => n.Visited == false))
                    {
                        //Cannot continue before all dependencies is completed
                        return "";
                    }
                    
                    Visited = true;
                    var seq = Name + string.Join("",
                                After
                                    .OrderBy((n) => n.Name)
                                    .Select(n => n.Sequence)
                                );
                    return seq;
                    }
                }
        }

        public static Node FindNode(Node tree, string name)
        {
            if (tree.Name == name)
            {
                return tree;
            }

            foreach(var after in tree.After)
            {
                var found = FindNode(after, name);
                if (found != null)
                    return found;
            }
            return null;
        }

        public static void First()
        {
            Node root = new Node() { Name = "" };
            var steps = stepSequence.Split(new[] { "\r\n" }, StringSplitOptions.None)
                    .Select( s => new Tuple<string, string>(s.Substring(5,1), s.Substring(36,1)))
                    .ToList();

            Console.WriteLine($"The instruction has {steps.Count} parts");

            foreach(var step in steps)
            {
                var subRoot = FindNode(root, step.Item1);
                if (subRoot == null)
                {
                    subRoot = new Node() { Name = step.Item1 };
                    subRoot.Parent.Add(root);
                    root.AddNode(subRoot);
                }

                var after = FindNode(root, step.Item2);

                if (after != null)
                {
                    // Remove node from temporary location.
                    if (after.Parent.First() == root)
                    {
                        // root.RemoveAfterNode(after);
                        after.RemoveParentNode(root);
                    }
                }
                else
                {
                    after = new Node() { Name = step.Item2 };
                }
                subRoot.AddNode(after);
            }

            Console.WriteLine($"The sequence is {root.Sequence}");
            //GJICKQTESBMVXRYUWLDFOPAHNZ
        }
        public static void Second()
        {
            Console.WriteLine($"No solution yet");
        }

        public static string stepSequence = @"Step G must be finished before step T can begin.
Step L must be finished before step V can begin.
Step D must be finished before step P can begin.
Step J must be finished before step K can begin.
Step N must be finished before step B can begin.
Step K must be finished before step W can begin.
Step T must be finished before step I can begin.
Step F must be finished before step E can begin.
Step P must be finished before step O can begin.
Step X must be finished before step I can begin.
Step M must be finished before step S can begin.
Step Y must be finished before step O can begin.
Step I must be finished before step Z can begin.
Step V must be finished before step Z can begin.
Step Q must be finished before step Z can begin.
Step H must be finished before step C can begin.
Step R must be finished before step Z can begin.
Step U must be finished before step S can begin.
Step E must be finished before step Z can begin.
Step O must be finished before step W can begin.
Step Z must be finished before step S can begin.
Step S must be finished before step C can begin.
Step W must be finished before step B can begin.
Step A must be finished before step B can begin.
Step C must be finished before step B can begin.
Step L must be finished before step P can begin.
Step J must be finished before step V can begin.
Step E must be finished before step W can begin.
Step Z must be finished before step W can begin.
Step W must be finished before step C can begin.
Step S must be finished before step W can begin.
Step Q must be finished before step S can begin.
Step O must be finished before step B can begin.
Step R must be finished before step W can begin.
Step D must be finished before step H can begin.
Step E must be finished before step O can begin.
Step Y must be finished before step H can begin.
Step V must be finished before step O can begin.
Step O must be finished before step S can begin.
Step X must be finished before step V can begin.
Step R must be finished before step E can begin.
Step S must be finished before step A can begin.
Step K must be finished before step Y can begin.
Step V must be finished before step W can begin.
Step U must be finished before step W can begin.
Step H must be finished before step R can begin.
Step P must be finished before step I can begin.
Step E must be finished before step C can begin.
Step H must be finished before step Z can begin.
Step N must be finished before step V can begin.
Step N must be finished before step W can begin.
Step A must be finished before step C can begin.
Step V must be finished before step E can begin.
Step N must be finished before step Q can begin.
Step Y must be finished before step V can begin.
Step R must be finished before step O can begin.
Step R must be finished before step C can begin.
Step L must be finished before step S can begin.
Step V must be finished before step R can begin.
Step X must be finished before step R can begin.
Step Z must be finished before step A can begin.
Step O must be finished before step Z can begin.
Step U must be finished before step C can begin.
Step X must be finished before step W can begin.
Step K must be finished before step O can begin.
Step O must be finished before step A can begin.
Step K must be finished before step T can begin.
Step N must be finished before step O can begin.
Step X must be finished before step C can begin.
Step Z must be finished before step C can begin.
Step N must be finished before step X can begin.
Step T must be finished before step A can begin.
Step D must be finished before step O can begin.
Step M must be finished before step Q can begin.
Step D must be finished before step C can begin.
Step U must be finished before step E can begin.
Step N must be finished before step H can begin.
Step I must be finished before step U can begin.
Step N must be finished before step A can begin.
Step M must be finished before step E can begin.
Step M must be finished before step V can begin.
Step P must be finished before step B can begin.
Step K must be finished before step X can begin.
Step N must be finished before step S can begin.
Step S must be finished before step B can begin.
Step Y must be finished before step W can begin.
Step K must be finished before step Q can begin.
Step V must be finished before step S can begin.
Step E must be finished before step S can begin.
Step N must be finished before step Z can begin.
Step P must be finished before step A can begin.
Step T must be finished before step V can begin.
Step L must be finished before step D can begin.
Step I must be finished before step C can begin.
Step Q must be finished before step E can begin.
Step Y must be finished before step U can begin.
Step J must be finished before step I can begin.
Step P must be finished before step H can begin.
Step T must be finished before step M can begin.
Step T must be finished before step E can begin.
Step D must be finished before step F can begin.";
    }
    public class Day_8
    {
        public static void First()
        {
            Console.WriteLine("No solution yet");
        }
        public static void Second()
        {
            Console.WriteLine("No solution yet");
        }
    }
    public class Day_9
    {
        public static void First()
        {
            Console.WriteLine("No solution yet");
        }
        public static void Second()
        {
            Console.WriteLine("No solution yet");
        }
    }
    public class Day_10
    {
        public static void First()
        {
            Console.WriteLine("No solution yet");
        }
        public static void Second()
        {
            Console.WriteLine("No solution yet");
        }
    }

}
