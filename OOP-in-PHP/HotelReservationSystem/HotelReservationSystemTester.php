<?php
function __autoload($className)
{
    include_once("./" . $className . ".class.php");
}

$firstQuest = new Guest("Georgi", "Dimitrov", 12548789);
$secondQuest = new Guest("Todor", "Jivkov", 2165418);
$thirdQuest = new Guest("Georgi", "Parvanov", 89466466);


$firstReservation = new Reservation("19-10-2014", "21-10-2014", $firstQuest);
$secondReservation = new Reservation("20-10-2014", "25-10-2014", $secondQuest);
$thirdReservation = new Reservation("18-10-2014", "26-10-2014", $thirdQuest);
$fourReservation = new Reservation("01-10-2014", "17-10-2014", $thirdQuest);

$rooms[201] = new SingleRoom(201, 40);
BookManager::bookRoom($rooms[201],$firstReservation);
BookManager::bookRoom($rooms[201], $fourReservation);

$rooms[305] = new SingleRoom(305, 60);
BookManager::bookRoom($rooms[305],$firstReservation);
BookManager::bookRoom($rooms[305], $secondReservation);

$rooms[401] = new SingleRoom(401, 40);
$rooms[412] = new Bedroom(412, 70);
$rooms[302] = new Bedroom(302, 80);
$rooms[202] = new Bedroom(202, 70);
$rooms[410] = new Bedroom(410, 80);

$rooms[501] = new Apartment(501, 200);
BookManager::bookRoom($rooms[501], $secondReservation);

$rooms[502] = new Apartment(502, 300);
$rooms[601] = new Apartment(601, 350);

echo PHP_EOL;
echo "Bedrooms and apartments with a price less or equal to 250.00";
echo PHP_EOL;
$filteredRooms = array_filter($rooms, "getBedroomsAndApartmentsByPrice");
function getBedroomsAndApartmentsByPrice(Room $room)
{
    if (($room instanceof Bedroom) || ($room instanceof Apartment)) {
        if ($room->getPrice() <= 250) {
            return true;
        }
    }
    return false;
}

foreach ($filteredRooms as $room) {
    echo "{$room->getRoomNumber()} - {$room->getRoomType()} - {$room->getPrice()}" . PHP_EOL;
}

echo PHP_EOL . "All rooms with a balcony";
echo PHP_EOL;
$filteredRoomsWithBalcony = array_filter($rooms, "getAllRoomsWithBalcony");
function getAllRoomsWithBalcony(Room $room)
{
    if ($room->hasBalcony()) {
        return true;
    }

    return false;
}

foreach ($filteredRoomsWithBalcony as $room) {
    echo "{$room->getRoomNumber()} - {$room->getRoomType()} - {$room->hasBalcony()}" . PHP_EOL;
}

echo PHP_EOL . "All room numbers of rooms which have a bathtub";
echo PHP_EOL;
$filteredRoomsWithBathtub = array_filter($rooms, "getAllRoomsWithBathtub");
$roomNumbers = array_map("returnRoomNumbers", $filteredRoomsWithBathtub);
function getAllRoomsWithBathtub(Room $room)
{
    if ($room->hasExtra(Extra::BATHTUB)) {
        return true;
    }

    return false;
}

function returnRoomNumbers($room) {
    return $room->getRoomNumber();
}

foreach ($roomNumbers as $roomNumber) {
    echo $roomNumber . PHP_EOL;
}

echo PHP_EOL . "All apartments which are not booked in a given time period";
echo PHP_EOL;
$allApartments = array_filter($rooms, "isApartment");
$allEmptyApartmentsForPeriod = array_filter($allApartments, "isEmpty");
function isApartment($room){
    return $room instanceof Apartment;
}

function isEmpty(Room $room){
    $quest = new Guest("G", "R", 89466466);
    $reservation = new Reservation("19-10-2014", "21-10-2014", $quest);
    try{
        $room->checkForValidReservation($reservation);
        return true;
    } catch (EReservationException $ex ){
        return false;
    }
}

foreach ($allEmptyApartmentsForPeriod as $apartment) {
    echo $apartment->getRoomNumber() . PHP_EOL;
}