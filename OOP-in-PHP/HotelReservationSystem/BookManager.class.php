<?php

class BookManager
{
    public static function bookRoom(Room $room, Reservation $reservation)
    {
        try {
            $room->addReservation($reservation);
            echo "\nRoom " . $room->getRoomNumber() . " successfully booked for "
                . $reservation->getGuest()->getFullName()
                . " from " . $reservation->getStartDate()->format("d-m-y")
                . " to " . $reservation->getEndDate()->format("d-m-y");
        } catch (EReservationException $ex) {
            echo PHP_EOL . $ex->getMessage();
        }
    }
} 