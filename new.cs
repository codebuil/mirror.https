﻿using System;
using System.Drawing;
using Cosmos.System.Graphics;
using Sys = Cosmos.System;
using Cosmos.Debug.Kernel;
using Point = Cosmos.System.Graphics.Point;



namespace Cosmos_Graphic_Subsytem
{
    public class Kernel : Sys.Kernel
    {

        public Debugger debugger = new Debugger("System", "CGS");

        private Canvas canvas;
        private Bitmap bitmap;
        
        protected override void BeforeRun()
        {
           
           
            
            
            Console.WriteLine("Cosmos booted successfully. Let's go in Graphic Mode");
            
            Mode start = new Mode(320, 200, ColorDepth.ColorDepth32);


            
            
            canvas = FullScreenCanvas.GetFullScreenCanvas(start);
            

            
            canvas.Clear(Color.Green);
        }

        protected override void Run()
        {
            try
            {
                canvas.DrawImage(getbits(), new Point(0, 0));


                canvas.Display();
                Console.ReadKey();

                Console.ReadKey();

                Sys.Power.Shutdown();
            }
            catch (Exception e)
            {

            }
        }
        Bitmap getbits() {
            bitmap = new Bitmap(24, 24, new byte[] {
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
139 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
255 , 255 , 255 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0 , 0 , 0 , 0xFF,
0
        }, ColorDepth.ColorDepth32);



            return bitmap;
        }
    }
}