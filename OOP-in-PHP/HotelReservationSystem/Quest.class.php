<?php
class Quest {
    private $firstName;
    private $secondName;
    private $id;

    /**
     * @param string $firstName
     * @param string $secondName
     * @param integer $id
     */
    function __construct($firstName, $secondName, $id)
    {
        $this->firstName = $firstName;
        $this->secondName = $secondName;
        $this->id = $id;
    }

    /**
     * @param string $firstName
     */
    public function setFirstName($firstName)
    {
        $this->firstName = $firstName;
    }

    /**
     * @return string
     */
    public function getFirstName()
    {
        return $this->firstName;
    }

    /**
     * @param string $id
     */
    public function setId($id)
    {
        $this->id = $id;
    }

    /**
     * @return string
     */
    public function getId()
    {
        return $this->id;
    }

    /**
     * @param string $secondName
     */
    public function setSecondName($secondName)
    {
        $this->secondName = $secondName;
    }

    /**
     * @return string
     */
    public function getSecondName()
    {
        return $this->secondName;
    }

    public function getFullName()
    {
        return "$this->firstName $this->secondName";
    }

    function __toString()
    {
        return $this->getFullName() .  " -  EGN: " . $this->id;
    }


}