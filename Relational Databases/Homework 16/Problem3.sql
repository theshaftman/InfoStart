SELECT
  dg.NOMERRAZP,
  dg.DATARAZP,
  dg.NOMERFAKT,
  dg.DATAFAKT,
  td.TIPDOC
FROM 
  STUDENT_IS.DOCUMENT_GL dg,
  STUDENT_IS.TIP_DOC td
WHERE
  td.TIP_DOC_ID = dg.TIP_DOC_ID AND
  td.TIPDOC IN ('Фактура', 'Стокова разписка за доставка')