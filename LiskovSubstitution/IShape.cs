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

     public interface IShape
    {
        void Display();
        string Export();
    }
}