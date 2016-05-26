/*! Rappid v1.7.1 - HTML5 Diagramming Framework - TRIAL VERSION

Copyright (c) 2015 client IO

 2016-03-03 


This Source Code Form is subject to the terms of the Rappid Trial License
, v. 2.0. If a copy of the Rappid License was not distributed with this
file, You can obtain one at http://jointjs.com/license/rappid_v2.txt
 or from the Rappid archive as was distributed by client IO. See the LICENSE file.*/


var Stencil = {};

Stencil.groups = {
    basic: { index: 1, label: 'Basic shapes' },
    lines: { index: 2, label: 'Links' }
};

Stencil.shapes = {

    basic: [
        new joint.shapes.basic.Rect({
            size: { width: 5, height: 3 },
            attrs: {
                rect: {
                    rx: 2, ry: 2, width: 50, height: 30,
                    fill: '#669999'
                },
                text: { text: 'rect', fill: '#ffffff', 'font-size': 10, stroke: '#000000', 'stroke-width': 0 }
            }
        }),
        new joint.shapes.basic.Circle({
            size: { width: 5, height: 3 },
            attrs: {
                circle: { width: 50, height: 30, fill: '#669999' },
                text: { text: 'ellipse', fill: '#ffffff', 'font-size': 10, stroke: '#000000', 'stroke-width': 0 }
            }
        }),
        new joint.shapes.devs.Atomic({
            size: { width: 4, height: 3 },
            inPorts: ['in1', 'in2'],
            outPorts: ['out'],
            attrs: {
                rect: { fill: '#669999', rx: 2, ry: 2 },
                '.label': { text: 'model', fill: '#ffffff', 'font-size': 10, stroke: '#000000', 'stroke-width': 0 },
                '.inPorts circle': { fill: '#f1c40f', opacity: 0.9 },
                '.outPorts circle': { fill: '#f1c40f', opacity: 0.9 },
                '.inPorts text, .outPorts text': { 'font-size': 9 }
            }
        })

    ],

    lines: [

       new joint.dia.Link({
           source: { x: 10, y: 20 },
           target: { x: 100, y: 20 },
           attrs: {
               '.connection': { stroke: 'black' },
               '.marker-source': { fill: 'blue', d: 'M 10 0 L 0 5 L 10 10 z' },
               '.marker-target': { fill: 'blue', d: 'M 10 0 L 0 5 L 10 10 z' }
           }
       })
            ,

       new joint.dia.Link({
           source: { x: 10, y: 60 },
           target: { x: 100, y: 60 },
           attrs: {
               '.connection': { stroke: '#e74c3c'},
               '.marker-source': { fill: '#e74c3c', d: 'm 10 0 l 0 5 l 10 10 z' },
               '.marker-target': { fill: '#e74c3c', d: 'm 10 0 l 0 5 l 10 10 z' }
           }
       })
            ,

        new joint.dia.Link({
            source: { x: 10, y: 120 },
            target: { x: 100, y: 120 },
            vertices: [{ x: 10, y: 120 }, { x: 45, y: 90 }, { x: 100, y: 120 }],
            attrs: {
                '.connection': { stroke: 'black' },
                '.marker-source': { fill: 'black', d: 'm 10 0 l 0 5 l 10 10 z' },
                '.marker-target': { fill: 'black', d: 'm 10 0 l 0 5 l 10 10 z' }
            }
        })
    ]
};


