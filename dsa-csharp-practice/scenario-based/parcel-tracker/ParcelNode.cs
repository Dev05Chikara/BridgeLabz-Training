using System;
class ParcelNode
{
    internal string parcelStage;
    public ParcelNode next;

    public ParcelNode(string parcelStage)
    {
        this.parcelStage= parcelStage;
        next=null;
    }
}