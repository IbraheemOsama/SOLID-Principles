using System;

namespace liskovSubstitution
{
    public interface IDisplay
    {
        void Display();
    }
    public interface IExport
    {
        string Export();
    }

     public interface IShapre
    {
        void Display();
        string Export();
    }
}