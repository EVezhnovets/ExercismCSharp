using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;
    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => knightIsAwake || archerIsAwake || prisonerIsAwake;
    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => !archerIsAwake && prisonerIsAwake;
    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent) => !archerIsAwake && (!knightIsAwake && prisonerIsAwake || petDogIsPresent);
    //public static bool CanFastAttack(bool knightIsAwake)
    //{
    //    bool IsPossible = false;
    //    if (knightIsAwake)
    //    {
    //        IsPossible = false;
    //    } else
    //    {
    //        IsPossible = true;
    //    }
    //    return IsPossible;
    //}

    //public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    //{
    //    bool IsSpy = default;

    //    if (knightIsAwake && archerIsAwake && prisonerIsAwake && !(prisonerIsAwake == knightIsAwake == archerIsAwake))
    //    {
    //    }
    //    else
    //    {
    //        IsSpy = true;
    //        if (!knightIsAwake && !archerIsAwake && !prisonerIsAwake)
    //        {
    //            IsSpy = false;
    //        }
    //    }
    //    return IsSpy;
    //}

    //public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    //{
    //    bool IsPossible = default;
    //    if (!archerIsAwake && prisonerIsAwake)
    //    {
    //        IsPossible = true;
    //    }
    //    return IsPossible;
    //}

    //public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    //{
    //    bool IsPossible = default;
    //    if(!archerIsAwake && prisonerIsAwake && knightIsAwake && petDogIsPresent || !archerIsAwake && prisonerIsAwake && !knightIsAwake && !petDogIsPresent  ||
    //       !archerIsAwake && !prisonerIsAwake && !knightIsAwake && petDogIsPresent || !archerIsAwake && prisonerIsAwake && !knightIsAwake && petDogIsPresent || !archerIsAwake && !prisonerIsAwake && knightIsAwake && petDogIsPresent)
    //    {
    //        IsPossible = true;
    //    } 

    //    return IsPossible;
    //}
}
