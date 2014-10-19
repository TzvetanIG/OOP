<?php
require_once("iReservable.class.php");

abstract class Room implements iReservable
{
    private $reservations = [];
    private $hasRestroom;
    private $hasBalcony;
    private $bedCount;
    private $roomNumber;
    private $price;
    private $roomType;
    private $extras = [];

    public function __construct($roomNumber, $bedCount, $price, $hasRestroom, $hasBalcony, $roomType)
    {
        $this->bedCount = $bedCount;
        $this->roomNumber = $roomNumber;
        $this->price = $price;
        $this->hasRestroom = $hasRestroom;
        $this->hasBalcony = $hasBalcony;
        $this->roomType = $roomType;
    }

    /**
     * @return integer
     */
    public function getBedCount()
    {
        return $this->bedCount;
    }

    /**
     * @return integer
     */
    public function getRoomNumber()
    {
        return $this->roomNumber;
    }

    /**
     * @return string
     */
    public function getRoomType()
    {
        return $this->roomType;
    }

    /**
     * @return double
     */
    public function getPrice()
    {
        return $this->price;
    }

    /**
     * @return boolean
     */
    public function hasBalcony()
    {
        return $this->hasBalcony;
    }

    /**
     * @return boolean
     */
    public function hasRestroom()
    {
        return $this->hasRestroom;
    }

    public function __toString()
    {
        $resultString = "Room number: $this->roomNumber - type: $this->roomType\n";
        foreach ($this->reservations as $reservation) {
            $resultString .= $reservation->__toString() . PHP_EOL;
        }

        return $resultString;
    }

    public function addReservation($reservation)
    {
        $this->checkForValidReservation($reservation);
        $this->reservations[] = $reservation;
    }

    public function  hasExtra($extra)
    {
        return in_array($extra, $this->extras);
    }

    protected function addExtras($extras)
    {
        $this->extras[] = $extras;
    }

    public  function  checkForValidReservation(Reservation $reservation)
    {
        foreach ($this->reservations as $existingReservation) {
            if (($reservation->getStartDate() >=  $existingReservation->getStartDate()  &&
                $reservation->getStartDate() <=  $existingReservation->getEndDate())
            ) {
                throw new EReservationException($this->roomNumber, $reservation);
            } elseif (($reservation->getEndDate() >=  $existingReservation->getStartDate()  &&
                $reservation->getEndDate()  <=   $existingReservation->getEndDate())
            ) {
                throw new EReservationException($this->roomNumber, $reservation);
            }
        }
    }
}