﻿SELECT
  STUDENT_IS.CLIENTS.FIRMA,
  STUDENT_IS.CLIENTS.MOL,
  STUDENT_IS.CLIENTS.ADRES
FROM
  STUDENT_IS.CLIENTS
WHERE
  STUDENT_IS.CLIENTS.MOL IS NOT NULL AND
  STUDENT_IS.CLIENTS.ADRES IS NOT NULL