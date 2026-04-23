using System;
using Objectlnitializers;

PointReadOnlyAfterCreation firstReadOnlyPoint = new PointReadOnlyAfterCreation(20,20);
firstReadOnlyPoint.DisplayStats();

PointReadOnlyAfterCreation secondReadOnlyPoint = new PointReadOnlyAfterCreation(30,30);
secondReadOnlyPoint.DisplayStats();