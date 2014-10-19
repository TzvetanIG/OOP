<?php
require_once "Room.class.php";

class Apartment extends Room {
    const BED_COUNT = 4;

    function __construct($roomNumber, $price)
    {
        parent::__construct($roomNumber, Apartment::BED_COUNT, $price, true, true, RoomType::DIAMOND);
        $this->addExtras(Extra::TV);
        $this->addExtras(Extra::AIR_CONDITIONER);
        $this->addExtras(Extra::REFRIGERATOR);
        $this->addExtras(Extra::MINI_BAR);
        $this->addExtras(Extra::BATHTUB);
        $this->addExtras(Extra::FREE_WI_FI);
        $this->addExtras(Extra::KITCHEN_BOX);
    }
} 