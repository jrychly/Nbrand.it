using System;
using System.Collections.Generic;
using System.Drawing;

public class AllImages{
    public List<string> Images;
    public List<string> vals;

    public void Generate(){
        Images = new List<string>();
        Images.Add("1.jpg");
        Images.Add("2.jpg");
        Images.Add("3.jpg");
        Images.Add("4.jpg");
    }

    public void Calc(){
        vals = new List<string>();
        vals.Add("95%");
        vals.Add("46% (same text)");
        vals.Add("31% (simmilar text)");
        vals.Add("11%");
    }
}