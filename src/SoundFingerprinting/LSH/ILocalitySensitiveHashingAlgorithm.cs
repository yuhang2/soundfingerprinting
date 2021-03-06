﻿namespace SoundFingerprinting.LSH
{
    using SoundFingerprinting.Data;

    public interface ILocalitySensitiveHashingAlgorithm
    {
        HashData Hash(bool[] fingerprint, int numberOfHashTables, int numberOfHashKeysPerTable);
    }
}