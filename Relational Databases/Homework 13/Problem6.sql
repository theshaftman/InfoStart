﻿SELECT
  v.VALUTA_NAME,
  vr.STOJNOST,
  vr.DATE_V
FROM
  STUDENT_IS.VALUTA v JOIN 
  STUDENT_IS.VALUTA_RE vr 
USING (ID_V)