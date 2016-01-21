using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveBits
{
    class waveBits
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            bool isInWave = false;
            byte currentBit = 0;
            int start = 0;
            int end = 0;
            int largestWaveStart = 0;
            int largestWaveEnd = 0;

            Console.WriteLine(Convert.ToString((long)number, 2).PadLeft(64, '0'));

            for (int bitPos = 0; bitPos < 64; bitPos++)
            {
                ulong mask = number >> bitPos;
                byte bit = (byte)(mask & 1);
                if (!isInWave)
                {
                    if (bit == 1)
                    {
                        isInWave = true;
                        currentBit = bit;
                        start = bitPos;
                    }
                }
                else
                {
                    if (bit != currentBit)
                    {
                        currentBit = bit;
                    }
                    else
                    {
                        isInWave = false;
                        if (currentBit == 1)
                        {
                            end = bitPos - 1;
                        }
                        else
                        {
                            end = bitPos - 2;
                        }
                        if (end - start != 0)
                        {
                            if((end - start) > (largestWaveEnd - largestWaveStart))
                            {
                                largestWaveStart = start;
                                largestWaveEnd = end;
                            }
                        }
                    }
                }
            }
            if (largestWaveStart - largestWaveEnd == 0)
            {
                Console.WriteLine("No waves found");
            }
            else
            {
                ulong rightMask = 0;
                for (int count = 0; count < largestWaveStart; count++)
                {
                    rightMask <<= 1;
                    rightMask |= 1;
                }
                ulong rightPart = rightMask & number;

                ulong leftPart = number >> largestWaveEnd + 1;


                ulong result = 0;
                result = rightPart;
                result |= (leftPart << largestWaveEnd + 1);
                Console.WriteLine(result);


            }
        }
    }
}
