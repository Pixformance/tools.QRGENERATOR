using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagGenerator
{
    class ModuloCodeGenerator
    {
        UInt32 current;
        UInt32 mod;
        UInt32 add;

        // Important, the last 3 bits should be 0 => ending in 8 or 0
        UInt32[] bitMasks = new UInt32[] {
              0xFA432DA8
            , 0xB52C76A0
            , 0x8A9AB568
            , 0x789E14D8
            , 0xFFFAAAC8
            , 0xABFD1228
            , 0x561F4720
            , 0x340F0230
        };

        // Important: mod and add must be coprime (note tested in the code)
        public ModuloCodeGenerator(UInt32 seed = 42, UInt32 _mod = ~((UInt32) 0), UInt32 _add = 4090392781)
        {
            mod = _mod;
            add = _add;
            setRawCurrent(seed);
        }

        // Sets the last number generated (without bitmasking)
        public void setCurrent(UInt32 _current)
        {
            current = _current;
        }

        // Sets the last number generated in "raw" mode, i.e. bit masking must still be applied
        private void setRawCurrent(UInt32 rawCurrent)
        {
            current = rawCurrent ^ (bitMasks[rawCurrent % bitMasks.Length]);
        }

        private UInt32 getRawCurrent()
        {
            return current ^ (bitMasks[current % bitMasks.Length]);
        }
        
        public UInt32 next()
        {
            UInt32 currentRaw = getRawCurrent();
            UInt64 x = currentRaw + add;
            UInt32 newRaw = (UInt32)(x % mod);
            setRawCurrent(newRaw);

            return current;
        }
    }
}
