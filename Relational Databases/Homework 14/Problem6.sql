﻿SELECT DISTINCT
(SELECT 
  COUNT(*)
FROM 
  STUDENT_IS.DOCUMENT_GL dg 
WHERE 
  dg.NOMERFAKT IS NULL) AS "COUNT_NULL",
(SELECT
  COUNT(*)
FROM 
  STUDENT_IS.DOCUMENT_GL dg1 
WHERE 
  dg1.NOMERFAKT IS NOT NULL) AS "COUNT_NOT_NULL",
  (
SELECT 
  COUNT(dg2.ID_M) 
FROM 
  STUDENT_IS.DOCUMENT_GL dg2) AS "COUNT_ALL"
FROM
  STUDENT_IS.DOCUMENT_GL dg3