﻿SELECT 
  FIRMA,
  NVL(BULSTAT,'Не е въведена') as BULSTAT
FROM
  STUDENT_IS.CLIENTS