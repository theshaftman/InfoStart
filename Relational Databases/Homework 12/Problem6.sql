SELECT 
  OPERATOR_NAME AS "Име на служител",
  ZAPLATA AS "Месечна заплата",
  ROUND(ZAPLATA/22/8,2) AS "Часова ставка"
FROM
  STUDENT_IS.OPERATORS