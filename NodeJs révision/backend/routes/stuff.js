
const express = require('express');
const router = express.Router();

const Thing = require('../models/thing');
const stuffController = require('../controller/stuffController');

router.post('/', stuffController.createThing)


router.get('/:id', stuffController.getOneThing)

router.put('/:id',stuffController.modifyThing)

router.delete('/:id',stuffController.deleteThing)

router.get('/' + '', stuffController.getAllStuff)

module.exports = router;

