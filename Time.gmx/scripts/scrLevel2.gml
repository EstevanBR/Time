//entrance door = 100090
//exit door = 100092
//button that opens the exit door = 100102

if place_meeting((button).x,(button).y-1,objPlayer)
    {
        {
            (button).status = 1
            (door1).sprite_index = sprOpenDoor
        }
        (button).image_index = 2
    }else{
        {(door1).status = 0
        (button).image_index = 0 
        (door1).sprite_index = sprDoor}
    }
;

if (door1).status = 1
    {
        if place_meeting((door1).x,(door1).y,objPlayer)
            {
                room_goto(roomLevel2)
            }
    }
;
