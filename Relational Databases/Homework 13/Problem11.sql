﻿SELECT
  p.PRODNAME,
  s.KOLICHESTWO,
  ws.SKLAD_NAME
FROM
  STUDENT_IS.SKLAD s INNER JOIN
  STUDENT_IS.WID_SKLAD ws
  ON (s.SKLAD_ID = ws.SKLAD_ID) INNER JOIN
  STUDENT_IS.PRODUCTS p
  ON (p.PRODKOD_ID = s.PRODKOD_ID)
WHERE
  LOWER(ws.SKLAD_NAME) = 'склад брак'