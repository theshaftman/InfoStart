﻿SELECT
  p.PRODNAME,
  p.PRODAJNACENA,
  s.KOLICHESTWO
FROM
  STUDENT_IS.PRODUCTS p JOIN
  STUDENT_IS.SKLAD s USING (PRODKOD_ID)