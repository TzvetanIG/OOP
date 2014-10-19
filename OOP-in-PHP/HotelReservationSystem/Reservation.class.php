<?php

class Reservation
{
    private $startDate;
    private $endDate;
    private $guest;

    /**
     * @param string $startDate  Data in format "d-m-y".
     * @param string $endDate Data in format "d-m-y".
     * @param Guest $guest
     */
    function __construct($startDate, $endDate, Guest $guest)
    {
        $this->startDate = new DateTime($startDate);
        $this->endDate =  new DateTime($endDate);
        $this->guest = $guest;
    }

    /**
     * @param \Guest $guest
     */
    public function setGuest($guest)
    {
        $this->guest = $guest;
    }

    /**
     * @return \Guest
     */
    public function getGuest()
    {
        return $this->guest;
    }

    /**
     * @param \DateTime $endDate
     */
    public function setEndDate($endDate)
    {
        $this->endDate = $endDate;
    }

    /**
     * @return \DateTime
     */
    public function getEndDate()
    {
        return $this->endDate;
    }

    /**
     * @param \DateTime $startDate
     */
    public function setStartDate($startDate)
    {
        $this->startDate = $startDate;
    }

    /**
     * @return \DateTime
     */
    public function getStartDate()
    {
        return $this->startDate;
    }

    function __toString()
    {
        return "Start Date: " . $this->startDate->format("d-m-y") . "\n"
        . "End Date: " . $this->endDate->format("d-m-y") . "\n"
        . $this->guest->__toString();
    }


} 