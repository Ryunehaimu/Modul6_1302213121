﻿// See https://aka.ms/new-console-template for more information
using Modul6_1302213121;

SayaTubeUser user = new SayaTubeUser("Dede");
SayaTubeVideo video1 = new SayaTubeVideo("Naruto");
SayaTubeVideo video2 = new SayaTubeVideo("John Wick 1");
SayaTubeVideo video3 = new SayaTubeVideo("John Wick 2");
SayaTubeVideo video4 = new SayaTubeVideo("John Wick 3");
SayaTubeVideo video5 = new SayaTubeVideo("John Wick 4");
SayaTubeVideo video6 = new SayaTubeVideo("Tom And Jerry 1");
SayaTubeVideo video7 = new SayaTubeVideo("Tom And Jerry 2");
SayaTubeVideo video8 = new SayaTubeVideo("Tom And Jerry 3");
SayaTubeVideo video9 = new SayaTubeVideo("Tom And Jerry 4");
SayaTubeVideo video10 = new SayaTubeVideo("Tom And Jerry 5");

video1.increasePlayCount(5);
video2.increasePlayCount(1);
video3.increasePlayCount(3);
video4.increasePlayCount(2);
video5.increasePlayCount(1);
video6.increasePlayCount(1);
video7.increasePlayCount(1);
video8.increasePlayCount(1);
video9.increasePlayCount(1);
video10.increasePlayCount(1);

Console.WriteLine("Review Film 1 " + video1.title + " Oleh Dede");
user.AddVideo(video1);
Console.WriteLine("Menambahkan FILM :");
video1.PrintVideoDetails();
Console.WriteLine("Review Film 2 " + video1.title + " Oleh Dede");
user.AddVideo(video2);
Console.WriteLine("Menambahkan FILM :");
video2.PrintVideoDetails();
Console.WriteLine("Review Film 3 " + video1.title + " Oleh Dede");
user.AddVideo(video3);
Console.WriteLine("Menambahkan FILM :");
video3.PrintVideoDetails();
Console.WriteLine("Review Film 4 " + video1.title + " Oleh Dede");
user.AddVideo(video4);
Console.WriteLine("Menambahkan FILM :");
video4.PrintVideoDetails();
Console.WriteLine("Review Film 5 " + video1.title + " Oleh Dede");
user.AddVideo(video5);
Console.WriteLine("Menambahkan FILM :");
video5.PrintVideoDetails();
Console.WriteLine("Review Film 6 " + video1.title + " Oleh Dede");
user.AddVideo(video6);
Console.WriteLine("Menambahkan FILM :");
video6.PrintVideoDetails();
user.AddVideo(video7);
Console.WriteLine("Review Film 7 " + video1.title + " Oleh Dede");
Console.WriteLine("Menambahkan FILM :");
video7.PrintVideoDetails();
user.AddVideo(video8);
Console.WriteLine("Review Film 8 " + video1.title + " Oleh Dede");
Console.WriteLine("Menambahkan FILM :");
video8.PrintVideoDetails();
Console.WriteLine("Review Film 9 " + video1.title + " Oleh Dede");
user.AddVideo(video9);
Console.WriteLine("Menambahkan FILM :");
video9.PrintVideoDetails();
Console.WriteLine("Review Film 10 " + video1.title + " Oleh Dede");
user.AddVideo(video10);
Console.WriteLine("Menambahkan FILM :");
video10.PrintVideoDetails();

user.PrintAllVideoPlaycount();