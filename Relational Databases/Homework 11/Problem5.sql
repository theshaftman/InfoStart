﻿SELECT
  STUDENT_IS.OPERATORS.OPERATOR_NAME AS "ИМЕ НА ОПЕРАТОР",
  STUDENT_IS.OPERATORS.DLAZNOST AS ДЛЪЖНОСТ
FROM
  STUDENT_IS.OPERATORS
WHERE
  LOWER(STUDENT_IS.OPERATORS.DLAZNOST) NOT LIKE 'началник%'