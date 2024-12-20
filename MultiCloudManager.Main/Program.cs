﻿var osType = OS.Android;

Navgation nav = osType switch
{
    OS.Android => new Android(),
    OS.IOS => new IOS(),
    _ => throw new Exception()
};

nav.Back();

interface Navgation
{
    void Back();
    void Home();
}

class IOS : Navgation
{
    public void Back()
    {

        // call IOS kernal
    }

    public void Home()
    {
        // call IOS kernal
    }
}

class Android : Navgation
{
    public void Back()
    {
        // call Android kernal
    }

    public void Home()
    {
        // call Android kernal
    }
}

enum OS
{
    Android,
    IOS
}