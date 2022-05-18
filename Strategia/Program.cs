

using Strategia;

var strategy = new BikeStrategy();

var map = new Map(strategy);

var start = new Coordinate();
var end = new Coordinate();

map.CreateRoute(start, end);