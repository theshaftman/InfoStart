﻿SELECT
  dg.NOMERFAKT,
  dg.DATAFAKT,
  v.VALUTA_NAME,
  c.FIRMA
FROM
  STUDENT_IS.DOCUMENT_GL dg, 
  STUDENT_IS.VALUTA v, 
  STUDENT_IS.CLIENTS c
WHERE
  dg.ID_V = v.ID_V OR
  dg.ID_CLIENT = c.ID_CLIENT