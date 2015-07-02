SELECT
  dg.NOMERRAZP,
  dg.DATARAZP,
  'Стокова разписка' AS "Име на документа"
FROM 
  STUDENT_IS.DOCUMENT_GL dg
WHERE
  dg.TIP_DOC_ID = 2
UNION ALL
SELECT
  dg.NOMERRAZP,
  dg.DATARAZP,
  'Фактура' AS "Име на документа"
FROM 
  STUDENT_IS.DOCUMENT_GL dg
WHERE
  dg.TIP_DOC_ID = 1