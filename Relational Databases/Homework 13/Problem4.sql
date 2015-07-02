﻿SELECT
  dg.NOMERFAKT,
  dg.DATAFAKT,
  v.VALUTA_NAME,
  c.FIRMA
FROM
  STUDENT_IS.DOCUMENT_GL dg
  INNER JOIN STUDENT_IS.VALUTA v
  ON (dg.ID_V = v.ID_V)
  INNER JOIN STUDENT_IS.CLIENTS c
  ON (dg.ID_CLIENT = c.ID_CLIENT)