﻿SELECT
  o.OPERATOR_NAME,
  dg.NOMERFAKT
FROM 
  STUDENT_IS.DOCUMENT_GL dg INNER JOIN
  STUDENT_IS.OPERATORS o
  ON (dg.OPER_ID = o.OPER_ID)
WHERE
  dg.OPER_ID = 
(
SELECT DISTINCT
  o1.OPER_ID
FROM 
  STUDENT_IS.OPERATORS o1
WHERE
  o1.OPER_ID_MASTER = 
(
SELECT DISTINCT
  o2.OPER_ID
FROM 
  STUDENT_IS.OPERATORS o2
WHERE
  LOWER(o2.OPERATOR_NAME) = 'рени енчева'))