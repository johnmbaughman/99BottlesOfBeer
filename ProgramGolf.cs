using System;class _99{static void Main(){int b=99; while(b > 0){Console.WriteLine($"{b} bottle{(b>1?"s":"")} of beer on the wall, {b} bottle{(b>1?"s":"")} of beer.");Console.WriteLine($"Take one down and pass it around, {(b-->1?(b).ToString():"no more")} bottle{(b!=1?"s":"")} of beer on the wall.\n");}Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.");}}
