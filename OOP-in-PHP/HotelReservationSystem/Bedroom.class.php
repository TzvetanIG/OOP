<?php
class Bedroom extends Room {
    function __construct($roomNumber, $price)
    {
        parent::__construct($roomNumber, 2, $price, true, true, RoomType::GOLD);
        $this->addExtras(Extra::TV);
        $this->addExtras(Extra::AIR_CONDITIONER);
        $this->addExtras(Extra::REFRIGERATOR);
        $this->addExtras(Extra::MINI_BAR);
        $this->addExtras(Extra::BATHTUB);
    }
} 