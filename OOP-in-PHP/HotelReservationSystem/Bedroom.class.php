<?php
require_once "Room.class.php";

class Bedroom extends Room {
    const BED_COUNT = 2;

    function __construct($roomNumber, $price)
    {
        parent::__construct($roomNumber, Bedroom::BED_COUNT, $price, true, true, RoomType::GOLD);
        $this->addExtras(Extra::TV);
        $this->addExtras(Extra::AIR_CONDITIONER);
        $this->addExtras(Extra::REFRIGERATOR);
        $this->addExtras(Extra::MINI_BAR);
        $this->addExtras(Extra::BATHTUB);
    }
} 