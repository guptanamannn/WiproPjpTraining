select title from titles inner join publishers on titles.pub_id=publishers.pub_id where publishers.city like 'b%'