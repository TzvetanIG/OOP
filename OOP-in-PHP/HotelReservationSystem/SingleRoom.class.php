<?php

class SingleRoom extends Room {
    function __construct($roomNumber, $price)
    {
        parent::__construct($roomNumber, 1, $price, true, false, RoomType::STANDARD);
        $this->addExtras(Extra::TV);
        $this->addExtras(Extra::AIR_CONDITIONER);
    }
}