// See https://aka.ms/new-console-template for more information
using AwWidgetsCore.services;
using AwWidgetsCore.models;
using AwWidgetsCore.controllers;

Console.WriteLine("Program is starting...");
/*
// General Gaze Data Test
Console.WriteLine("STARING GENERAL GAZE DATA TEST:");
var gazeService = new AwGeneralGazeService<GeneralGazeData>(); //publisher

var gazeData = new GeneralGazeData(true);

gazeService.data = gazeData;
var gazeController = new AwGeneralGazeController<GeneralGazeData>(); //subscriber

gazeService.GazeDataObtained += gazeController.OnGazeDataObtained;

gazeService.obtainGazeData();


// Specific Gaze Data Test

Console.WriteLine("STARING SPECIFIC GAZE DATA TEST:");

var specificGazeService = new AwGeneralGazeService<SpecificGazeData>(); //publisher

var specificGazeData = new SpecificGazeData(new Point(10,0));

specificGazeService.data = specificGazeData;
var specificGazeController = new AwGeneralGazeController<SpecificGazeData>(); //subscriber

specificGazeService.GazeDataObtained += specificGazeController.OnGazeDataObtained;

specificGazeService.obtainGazeData();
/*
*/