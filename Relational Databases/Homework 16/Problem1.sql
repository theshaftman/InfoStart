﻿SELECT
  c.MOL,
  'CLIENTS' AS "Таблица"
FROM
  STUDENT_IS.CLIENTS c
UNION ALL
SELECT
  O.OPERATOR_NAME,
  'OPERATORS' AS "Таблица"
FROM
  STUDENT_IS.OPERATORS o