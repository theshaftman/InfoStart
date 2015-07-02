﻿SELECT
  ws.SKLAD_NAME,
  p.PRODNAME,
  s.KOLICHESTWO
FROM
  STUDENT_IS.SKLAD s
  INNER JOIN STUDENT_IS.WID_SKLAD ws
  ON (s.SKLAD_ID = ws.SKLAD_ID)
  INNER JOIN STUDENT_IS.PRODUCTS p
  ON (s.PRODKOD_ID = p.PRODKOD_ID)